﻿using Reloaded.Memory.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaModelLibrary
{
    public class LobbyActionCommon : AquaCommon
    {
        public lacHeader header;
        public dataInfo info;
        public List<dataBlockData> dataBlocks = new List<dataBlockData>();

        public struct lacHeader
        {
            public int lacMagic;
            public int reserve0;
            public int reserve1;
            public int reserve2;

            public int dataInfoPointer;
            public int reserve3;
            public int unkInt0;
        }

        public struct dataInfo
        {
            public int blockCount;
            public int blockOffset;
        }

        public struct dataBlock
        {
            public int unkInt0;
            public int internalName0Offset;
            public int chatCommandOffset;
            public int internalName1Offset;

            public int lobbyActionIdOffset;
            public int commonReferenceOffset0; //Used in common.text
            public int commonReferenceOffset1; //?? Not sure the deal with that
            public int unkIntOffset0;          //Human related?

            public int unkIntOffset1;          //Cast male related?
            public int unkIntOffset2;          //Cast female related?
            public int iceNameOffset;
            public int humanAqmOffset;

            public int castAqmOffset1;
            public int castAqmOffset2;
            public int kmnAqmOffset;
            public int vfxOffset;
        }

        public class dataBlockData
        {
            public int unkInt0;
            public string internalName0;
            public string chatCommand;
            public string internalName1;

            public string lobbyActionId;
            public string commonReference0;
            public string commonReference1;
            public int unkOffsetInt0; 

            public int unkOffsetInt1; 
            public int unkOffsetInt2;
            public string iceName;
            public string humanAqm;

            public string castAqm1;
            public string castAqm2;
            public string kmnAqm;
            public string vfxIce;
        }

        public static dataBlockData ReadDataBlock(BufferedStreamReader streamReader, int offset, dataBlock offsetBlock)
        {
            dataBlockData data = new dataBlockData();

            data.unkInt0 = offsetBlock.unkInt0;
            streamReader.Seek(offsetBlock.internalName0Offset + offset, System.IO.SeekOrigin.Begin);
            data.internalName0 = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.chatCommandOffset + offset, System.IO.SeekOrigin.Begin);
            data.chatCommand = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.internalName1Offset + offset, System.IO.SeekOrigin.Begin);
            data.internalName1 = AquaObjectMethods.ReadCString(streamReader);

            streamReader.Seek(offsetBlock.lobbyActionIdOffset + offset, System.IO.SeekOrigin.Begin);
            data.lobbyActionId = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.commonReferenceOffset0 + offset, System.IO.SeekOrigin.Begin);
            data.commonReference0 = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.commonReferenceOffset1 + offset, System.IO.SeekOrigin.Begin);
            data.commonReference1 = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.unkIntOffset0 + offset, System.IO.SeekOrigin.Begin);
            data.unkOffsetInt0 = streamReader.Read<int>();

            streamReader.Seek(offsetBlock.unkIntOffset1 + offset, System.IO.SeekOrigin.Begin);
            data.unkOffsetInt1 = streamReader.Read<int>();
            streamReader.Seek(offsetBlock.unkIntOffset2 + offset, System.IO.SeekOrigin.Begin);
            data.unkOffsetInt2 = streamReader.Read<int>();
            streamReader.Seek(offsetBlock.iceNameOffset + offset, System.IO.SeekOrigin.Begin);
            data.iceName = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.humanAqmOffset + offset, System.IO.SeekOrigin.Begin);
            data.humanAqm = AquaObjectMethods.ReadCString(streamReader);

            streamReader.Seek(offsetBlock.castAqmOffset1 + offset, System.IO.SeekOrigin.Begin);
            data.castAqm1 = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.castAqmOffset2 + offset, System.IO.SeekOrigin.Begin);
            data.castAqm2 = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.kmnAqmOffset + offset, System.IO.SeekOrigin.Begin);
            data.kmnAqm = AquaObjectMethods.ReadCString(streamReader);
            streamReader.Seek(offsetBlock.vfxOffset + offset, System.IO.SeekOrigin.Begin);
            data.vfxIce = AquaObjectMethods.ReadCString(streamReader);

            return data;
        }

    }
}
