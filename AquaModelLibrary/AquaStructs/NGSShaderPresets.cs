﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static AquaModelLibrary.NGSAquaObject;

namespace AquaModelLibrary
{
    //Autogenerated presets from existing models
    public static class NGSShaderPresets
    {
        public static Dictionary<string, SHADDetail> NGSShaderDetailPresets = new Dictionary<string, SHADDetail>(){
        {"1000p 1000", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1000r 1000", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1001p 1001", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1001r 1001", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1002r 1002", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1003r 1003", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1004r 1004", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1006r 1006", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1007r 1007", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1008r 1008", CreateDetail(0, 3, 0, 3, 0, 0, 0, 0)},
        {"1009r 1009", CreateDetail(0, 3, 0, 3, 0, 0, 0, 0)},
        {"1010r 1010", CreateDetail(0, 3, 0, 1, 0, 2, 0, 0)},
        {"1019r 1019", CreateDetail(0, 2, 0, 2, 0, 0, 0, 0)},
        {"1023r 1023", CreateDetail(0, 2, 0, 1, 0, 1, 0, 0)},
        {"1024r 1024", CreateDetail(0, 2, 0, 1, 0, 1, 0, 0)},
        {"1025r 1025", CreateDetail(0, 2, 0, 1, 0, 1, 0, 0)},
        {"1026r 1026", CreateDetail(0, 2, 0, 1, 0, 1, 0, 0)},
        {"1027r 1027", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1033r 1033", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1034r 1034", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1038r 1038", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1040r 1040", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1050r 1050", CreateDetail(0, 4, 0, 2, 0, 2, 0, 0)},
        {"1055r 1055", CreateDetail(0, 7, 3, 2, 1, 1, 0, 0)},
        {"1056r 1056", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1060r 1060", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1061r 1061", CreateDetail(0, 7, 2, 5, 0, 0, 0, 0)},
        {"1063r 1063", CreateDetail(0, 3, 0, 2, 0, 1, 0, 0)},
        {"1066r 1066", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1080r 1080", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1200p 1200", CreateDetail(0, 3, 0, 2, 0, 1, 0, 0)},
        {"1201p 1201", CreateDetail(0, 5, 0, 4, 0, 1, 0, 0)},
        {"1209p 1209", CreateDetail(0, 5, 0, 4, 0, 1, 0, 0)},
        {"1220p 1220", CreateDetail(0, 8, 0, 5, 0, 3, 0, 0)},
        {"1221p 1221", CreateDetail(0, 2, 0, 1, 0, 1, 0, 0)},
        {"1222p 1222", CreateDetail(0, 6, 0, 3, 0, 3, 0, 0)},
        {"1300p 1300", CreateDetail(0, 3, 0, 1, 0, 2, 0, 0)},
        {"1300r 1300", CreateDetail(0, 3, 0, 1, 0, 2, 0, 0)},
        {"1301p 1301", CreateDetail(0, 3, 0, 1, 0, 2, 0, 0)},
        {"1302p 1302", CreateDetail(0, 3, 0, 1, 0, 2, 0, 0)},
        {"1400p 1400", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1400r 1400", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        {"1401r 1401", CreateDetail(0, 2, 0, 2, 0, 0, 0, 0)},
        {"1402r 1402", CreateDetail(0, 1, 0, 1, 0, 0, 0, 0)},
        };
        public static Dictionary<string, List<SHADExtraEntry>> NGSShaderExtraPresets = new Dictionary<string, List<SHADExtraEntry>>(){
        {"1000p 1000", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1000r 1000", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1001p 1001", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1001r 1001", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1002r 1002", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1003r 1003", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1004r 1004", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1006r 1006", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1007r 1007", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1008r 1008", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "Metalness", 27949, 5090, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(8464, "Roughness", -10271, 6605, new Vector4(0.8f, 0f, 0f, 0f)),}},
        {"1009r 1009", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "Metalness", 27949, 5090, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(8464, "Roughness", -10271, 6605, new Vector4(0.8f, 0f, 0f, 0f)),}},
        {"1010r 1010", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "CstomBegin", -4201, 17620, new Vector4(0f, 0.6765f, 0f, 0f)), CreateExtra(5136, "CstomRange", -25319, -12005, new Vector4(0.02f, 0.02f, 1f, 1f)),}},
        {"1019r 1019", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "NrmlOffstR", 5726, 8124, new Vector4(0.2f, 0f, 0f, 0f)),}},
        {"1023r 1023", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1024r 1024", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(0.1671729f, 0.2577901f, 0.09244331f, 1f)),}},
        {"1025r 1025", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(0.1684193f, 0.2566363f, 0.09136625f, 1f)),}},
        {"1026r 1026", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(0.03914125f, 0.2176376f, 0.007626727f, 1f)),}},
        {"1027r 1027", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1033r 1033", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1034r 1034", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1038r 1038", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1040r 1040", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1050r 1050", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "TlngLength", 27466, 27055, new Vector4(10f, 0f, 0f, 0f)), CreateExtra(1040, "CstomBegin", -4201, 17620, new Vector4(0f, 0.5f, 0f, 0f)), CreateExtra(5136, "CstomRange", -25319, -12005, new Vector4(0f, 0.2f, 1f, 1f)),}},
        {"1055r 1055", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(257, "ImFramesX", 27609, -10998, new Vector4(6f, 0f, 0f, 0f)), CreateExtra(4353, "ImFramesY", 27610, -10998, new Vector4(6f, 0f, 0f, 0f)), CreateExtra(8513, "ImFlags", -8310, 11608, new Vector4(4.203895E-45f, 0f, 0f, 0f)), CreateExtra(4368, "DvByTneExp", 22289, 17894, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1025, "ImpstrWork", -24744, 19422, new Vector4(2.38109f, 12.31529f, 1.780282f, 26.97674f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(0.023378f, 0.071782f, 0.010813f, 1f)),}},
        {"1056r 1056", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1060r 1060", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1061r 1061", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(257, "GltchIntns", 17792, 13621, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4353, "GltchSpeed", 26544, 20244, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "ScanTiling", -17204, -4234, new Vector4(15f, 0f, 0f, 0f)), CreateExtra(8464, "ScanSpeed", 18038, 10115, new Vector4(2f, 0f, 0f, 0f)), CreateExtra(12560, "GlowTiling", 3395, -22686, new Vector4(1f, 0f, 0f, 0f)), CreateExtra(16656, "GlowSpeed", 17988, 6732, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1063r 1063", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(2.802597E-45f, 0f, 0f, 0f)), CreateExtra(4368, "EmisCoef", -10393, -14441, new Vector4(1f, 0f, 0f, 0f)), CreateExtra(1040, "EmisColor", 18352, 29062, new Vector4(1f, 0.8658f, 0f, 1f)),}},
        {"1066r 1066", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1080r 1080", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1200p 1200", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "SSSIntnsty", -2289, 19194, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1201p 1201", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "CstomBegin", -4201, 17620, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(8464, "CstomRange", -25319, -12005, new Vector4(0.1f, 0f, 0f, 0f)), CreateExtra(12560, "SSSIntnsty", -2289, 19194, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1209p 1209", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "FrStrength", -2804, 31920, new Vector4(1.8f, 0f, 0f, 0f)), CreateExtra(8464, "SSSIntnsty", -2289, 19194, new Vector4(0.5f, 0f, 0f, 0f)), CreateExtra(12560, "TilingRate", -22608, -12616, new Vector4(1f, 0f, 0f, 0f)), CreateExtra(1040, "SSSColor", 5702, 29330, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1220p 1220", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "BbblOffstR", 43, -6101, new Vector4(0.08f, 0f, 0f, 0f)), CreateExtra(8464, "BbblClrRte", -26585, 28858, new Vector4(3.5f, 0f, 0f, 0f)), CreateExtra(12560, "NrmlOffstR", 5726, 8124, new Vector4(0.2f, 0f, 0f, 0f)), CreateExtra(16656, "SSSIntnsty", -2289, 19194, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "BlndColor1", 8009, -3970, new Vector4(0.005f, 0f, 0f, 1f)), CreateExtra(5136, "BlndColor2", 8010, -3970, new Vector4(0.08f, 0.008000001f, 0.008000001f, 1f)), CreateExtra(9232, "SSSColor", 5702, 29330, new Vector4(0.6120656f, 0.2168723f, 0.2168723f, 1f)),}},
        {"1221p 1221", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(4.203895E-45f, 0f, 0f, 0f)), CreateExtra(1040, "EmisColor", 18352, 29062, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1222p 1222", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(4368, "NrmlOffstR", 5726, 8124, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(8464, "InsideRate", -24343, -15684, new Vector4(0.5f, 0f, 0f, 0f)), CreateExtra(1040, "BlndColor1", 8009, -3970, new Vector4(0.000348f, 0.003f, 0.0008536917f, 1f)), CreateExtra(5136, "BlndColor2", 8010, -3970, new Vector4(0.042042f, 0.539f, 0.2714047f, 1f)), CreateExtra(9232, "BlndColor3", 8011, -3970, new Vector4(0.04672901f, 0.3445744f, 0.563f, 1f)),}},
        {"1300p 1300", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "BlndColor1", 8009, -3970, new Vector4(1f, 1f, 1f, 1f)), CreateExtra(5136, "BlndColor2", 8010, -3970, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1300r 1300", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "BlndColor1", 8009, -3970, new Vector4(0f, 0f, 0f, 1f)), CreateExtra(5136, "BlndColor2", 8010, -3970, new Vector4(0f, 0f, 0f, 1f)),}},
        {"1301p 1301", new List<SHADExtraEntry>(){ CreateExtra(272, "NrmlOffstR", 5726, 8124, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "BlndColor1", 8009, -3970, new Vector4(1f, 1f, 1f, 1f)), CreateExtra(5136, "BlndColor2", 8010, -3970, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1302p 1302", new List<SHADExtraEntry>(){ CreateExtra(336, "ShaderID", -24734, 11562, new Vector4(0f, 0f, 0f, 0f)), CreateExtra(1040, "BlndColor1", 8009, -3970, new Vector4(1f, 1f, 1f, 1f)), CreateExtra(5136, "BlndColor2", 8010, -3970, new Vector4(1f, 1f, 1f, 1f)),}},
        {"1400p 1400", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1400r 1400", new List<SHADExtraEntry>(){ CreateExtra(336, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1401r 1401", new List<SHADExtraEntry>(){ CreateExtra(272, "EdgeRate", -15507, -5111, new Vector4(0.125f, 0f, 0f, 0f)), CreateExtra(4432, "ShdrCtgory", 11022, -5743, new Vector4(0f, 0f, 0f, 0f)),}},
        {"1402r 1402", new List<SHADExtraEntry>(){ CreateExtra(272, "OffsetRate", 12822, 26201, new Vector4(0.5f, 0f, 0f, 0f)),}},
        };
    }
}
