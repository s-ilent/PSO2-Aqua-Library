﻿using AquaModelLibrary.Nova.Structures;
using Reloaded.Memory.Streams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static AquaModelLibrary.AquaCommon;
using static AquaModelLibrary.Nova.AXSConstants;

namespace AquaModelLibrary.Nova
{
    public static class AAIMethods
    {
        public static AquaMotion ReadAAI(string filePath)
        {

            using (Stream stream = (Stream)new FileStream(filePath, FileMode.Open))
            using (var streamReader = new BufferedStreamReader(stream, 8192))
            {
                int fType = streamReader.Read<int>();
                if (fType != FAA)
                {
                    return null;
                }
                streamReader.Seek(0xC, SeekOrigin.Current);

                int innerFtype = streamReader.Read<int>();
                int len = streamReader.Read<int>();
                streamReader.Seek(len - 0x8, SeekOrigin.Current);

                int animDataMagic = streamReader.Read<int>();
                ushort nodeCount = streamReader.Read<ushort>();
                ushort sht_06 = streamReader.Read<ushort>();
                ushort sht_08 = streamReader.Read<ushort>();
                ushort sht_0C = streamReader.Read<ushort>();
                int timeCount = streamReader.Read<int>();

                int finalFrame = streamReader.Read<int>();
                int unkAddress0 = streamReader.Read<int>();
                int unkAddress1 = streamReader.Read<int>();
                int unkAddress2 = streamReader.Read<int>();

                int unkAddress3 = streamReader.Read<int>();
                int unkAddress4 = streamReader.Read<int>();
                int unkAddress5 = streamReader.Read<int>();
                int unkAddress6 = streamReader.Read<int>();

                int unkAddress7 = streamReader.Read<int>();
                int unkAddress8 = streamReader.Read<int>();
                int nodeDefEndAddress = streamReader.Read<int>();
                int unkAddress9 = streamReader.Read<int>();

                int unkAddress10 = streamReader.Read<int>();
                int int_44 = streamReader.Read<int>();

                int clumpCount = 0;
                List<AnimDefinitionNode> nodes = new List<AnimDefinitionNode>();
                int ct14 = 0;
                int ct24 = 0;
                int ct30 = 0;
                int ct34 = 0;
                int ct44 = 0;
                for(int i = 0; i < nodeCount; i++)
                {
                    AnimDefinitionNode node = new AnimDefinitionNode();
                    node.header0 = streamReader.Read<ushort>();
                    node.dataCount = streamReader.Read<ushort>();
                    node.len = streamReader.Read<int>();
                    node.nameData = streamReader.Read<PSO2String>();
                    node.name = node.nameData.GetString();
                    for(int j = 0; j < node.dataCount; j++)
                    {
                        clumpCount++;
                        var test = streamReader.Position().ToString("X");
                        DataClump dc = new DataClump();
                        dc.dcStart = streamReader.Read<DataClumpStart>();
                        switch(dc.dcStart.dcType)
                        {
                            case 0x14:
                                ct14++;
                                dc.d14 = streamReader.Read<DataClump14>();
                                break;
                            case 0x24:
                                ct24++;
                                dc.d24 = streamReader.Read<DataClump24>();
                                break;
                            case 0x30:
                                ct30++;
                                dc.d30 = streamReader.Read<DataClump30>();
                                break;
                            case 0x34:
                                ct34++;
                                dc.d34 = streamReader.Read<DataClump34>();
                                dc.dcString = dc.d34.clumpName.GetString();
                                break;
                            case 0x44:
                                ct44++;
                                dc.d44 = streamReader.Read<DataClump44>();
                                dc.dcString = dc.d44.clumpName.GetString();
                                break;
                            default:
                                MessageBox.Show($"clumpSize {dc.dcStart.dcType.ToString("X")} at {streamReader.Position().ToString("X")} is unexpected!");
                                break;
                        }
                        node.data.Add(dc);
                    }
                    nodes.Add(node);
                }

                //return null;

                var offsetTimes = streamReader.ReadOffsetTimeSets(streamReader.Position(), timeCount);
                List<List<OffsetTimeSet>> setsList = new List<List<OffsetTimeSet>>();

                for (int i = 0; i < offsetTimes.Count; i++)
                {
                    streamReader.Seek(offsetTimes[i].offset, SeekOrigin.Begin);
                    var position = streamReader.Position();
                    int keyNodeCount = streamReader.Read<int>();

                    List<OffsetTimeSet> sets = new List<OffsetTimeSet>();
                    for(int j = 0; j < keyNodeCount; j++)
                    {
                        OffsetTimeSet set = streamReader.Read<OffsetTimeSet>();
                        sets.Add(set);
                    }
                    setsList.Add(sets);
                }
            }
            return null;
        }

        public static List<OffsetTimeSet> ReadOffsetTimeSets(this BufferedStreamReader streamReader, long position, int timeCount)
        {
            List<OffsetTimeSet> sets = new List<OffsetTimeSet>();
            OffsetTimeSet set0 = new OffsetTimeSet() { offset = streamReader.Read<int>(), time = streamReader.Read<float>() };
            
            for(int i = 0; i < timeCount; i++)
            {
                //Add i * 8 to the offset for the true offset since the offsets here are relatigve to the position of their defining int
                OffsetTimeSet set = new OffsetTimeSet() { offset = (int)position + streamReader.Read<int>() + i * 8, time = streamReader.Read<float>() };
                sets.Add(set);
            }

            return sets;
        }
    }
}
