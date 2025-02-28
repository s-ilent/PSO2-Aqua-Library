﻿using AquaModelLibrary;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AquaModelTool.Forms.ModelSubpanels
{
    public partial class TextureReferenceEditor : UserControl
    {
        private List<AquaObject.TEXF> _texfList;
        private List<AquaObject.TSTA> _tstaList;
        private int curId;
        private bool canUpdate = false;
        public TextureReferenceEditor()
        {
            InitializeComponent();
        }

        public void UpdateTsta(List<AquaObject.TEXF> texfList, List<AquaObject.TSTA> tstaList, int id)
        {
            _texfList = texfList;
            _tstaList = tstaList;
            curId = id;
            canUpdate = false;

            if(id == -1 || tstaList.Count == 0 )
            {
                tagUD.Enabled = false;
                texNameTB.Enabled = false;
                orderUD.Enabled = false;
                uvSetUD.Enabled = false;
                unkFloat0UD.Enabled = false;
                unkFloat1UD.Enabled = false;
                unkFloat2UD.Enabled = false;
                unkFloat3UD.Enabled = false;
                unkFloat4UD.Enabled = false;

                unkVec3XUD.Enabled = false;
                unkVec3YUD.Enabled = false;
                unkVec3ZUD.Enabled = false;

                unkInt3UD.Enabled = false;
                unkInt4UD.Enabled = false;
                unkInt5UD.Enabled = false;

                var tsta = new AquaObject.TSTA();
                tagUD.Value = tsta.tag;
                texNameTB.Text = tsta.texName.GetString();
                orderUD.Value = tsta.texUsageOrder;
                uvSetUD.Value = tsta.modelUVSet;
                unkFloat0UD.Value = (decimal)tsta.unkFloat0;
                unkFloat1UD.Value = (decimal)tsta.unkFloat1;
                unkFloat2UD.Value = (decimal)tsta.unkFloat2;
                unkFloat3UD.Value = (decimal)tsta.unkFloat3;
                unkFloat4UD.Value = (decimal)tsta.unkFloat4;

                unkVec3XUD.Value = (decimal)tsta.unkVector0.X;
                unkVec3YUD.Value = (decimal)tsta.unkVector0.Y;
                unkVec3ZUD.Value = (decimal)tsta.unkVector0.Z;

                unkInt3UD.Value = tsta.unkInt3;
                unkInt4UD.Value = tsta.unkInt4;
                unkInt5UD.Value = tsta.unkInt5;
            } else
            {
                tagUD.Enabled = true;
                texNameTB.Enabled = true;
                orderUD.Enabled = true;
                uvSetUD.Enabled = true;
                unkFloat0UD.Enabled = true;
                unkFloat1UD.Enabled = true;
                unkFloat2UD.Enabled = true;
                unkFloat3UD.Enabled = true;
                unkFloat4UD.Enabled = true;

                unkVec3XUD.Enabled = true;
                unkVec3YUD.Enabled = true;
                unkVec3ZUD.Enabled = true;

                unkInt3UD.Enabled = true;
                unkInt4UD.Enabled = true;
                unkInt5UD.Enabled = true;

                var tsta = tstaList[id];
                tagUD.Value = tsta.tag;
                texNameTB.Text = tsta.texName.GetString();
                orderUD.Value = tsta.texUsageOrder;
                uvSetUD.Value = tsta.modelUVSet;
                unkFloat0UD.Value = (decimal)tsta.unkFloat0;
                unkFloat1UD.Value = (decimal)tsta.unkFloat1;
                unkFloat2UD.Value = (decimal)tsta.unkFloat2;
                unkFloat3UD.Value = (decimal)tsta.unkFloat3;
                unkFloat4UD.Value = (decimal)tsta.unkFloat4;

                unkVec3XUD.Value = (decimal)tsta.unkVector0.X;
                unkVec3YUD.Value = (decimal)tsta.unkVector0.Y;
                unkVec3ZUD.Value = (decimal)tsta.unkVector0.Z;

                unkInt3UD.Value = tsta.unkInt3;
                unkInt4UD.Value = tsta.unkInt4;
                unkInt5UD.Value = tsta.unkInt5;

                canUpdate = true;
            }

        }

        private void texNameTB_TextChanged(object sender, System.EventArgs e)
        {
            if(canUpdate)
            {
                var texf = _texfList[curId];
                var tsta = _tstaList[curId];
                tsta.texName.SetString(texNameTB.Text);
                tsta.texName.SetString(texNameTB.Text);
                _texfList[curId] = texf;
                _tstaList[curId] = tsta;
            }
        }

        private void tagUD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.tag = (int)tagUD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void orderUD_ValueChanged(object sender, System.EventArgs e)
            {
                if (canUpdate)
                {
                    var tsta = _tstaList[curId];
                    tsta.texUsageOrder = (int)orderUD.Value;
                    _tstaList[curId] = tsta;
                }
        }

        private void uvSetUD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.modelUVSet = (int)uvSetUD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkFloat0UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkFloat0 = (int)unkFloat0UD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkFloat1UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkFloat1 = (int)unkFloat1UD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkVec3XUD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkVector0.X = (int)unkVec3XUD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkVec3YUD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkVector0.Y = (int)unkVec3YUD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkVec3ZUD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkVector0.Z = (int)unkVec3ZUD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkFloat2UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkFloat2 = (int)unkFloat2UD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkFloat3UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkFloat3 = (int)unkFloat3UD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkInt3UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkInt3 = (int)unkInt3UD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkInt4UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkInt4 = (int)unkInt4UD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkInt5UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkInt5 = (int)unkInt5UD.Value;
                _tstaList[curId] = tsta;
            }
        }

        private void unkFloat4UD_ValueChanged(object sender, System.EventArgs e)
        {
            if (canUpdate)
            {
                var tsta = _tstaList[curId];
                tsta.unkFloat4 = (int)unkFloat4UD.Value;
                _tstaList[curId] = tsta;
            }
        }
    }
}
