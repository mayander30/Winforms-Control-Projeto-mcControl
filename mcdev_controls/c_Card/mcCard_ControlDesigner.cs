﻿using mcdev_controls.c_Card;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace mcdev_controls.c_Card
{
    public class mcCard_ControlDesigner : ParentControlDesigner
    {
        private DesignerActionListCollection actionLists;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            var contentsPanel = ((mcExpandCard)this.Control).ContentsPanel;
            this.EnableDesignMode(contentsPanel, "ContentsPanel");
        }

        public override bool CanParent(Control control)
        {
            return false;
        }

        protected override void OnDragOver(DragEventArgs de)
        {
            de.Effect = DragDropEffects.None;
        }

        protected override IComponent[] CreateToolCore(ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize)
        {
            return null;
        }

        // Use pull model to populate smart tag menu. 
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(
                        new mcCard_PropriedadesList(this.Component));
                }
                return actionLists;
            }
        }
    }

    public class mcCard_PropriedadesList : System.ComponentModel.Design.DesignerActionList
    {
        private mcExpandCard panel;

        private DesignerActionUIService designerActionUISvc = null;

        public mcCard_PropriedadesList(IComponent component)
            : base(component)
        {
            this.panel = component as mcExpandCard;
            this.designerActionUISvc =
                GetService(typeof(DesignerActionUIService))
                as DesignerActionUIService;
        }

        private PropertyDescriptor GetPropertyByName(String propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(panel)[propName];
            if (null == prop)
                throw new ArgumentException(
                    "Matching ExpandCollapsePanel property not found!",
                    propName);
            else
                return prop;
        }


        public String _TextHeader
        {
            get
            {
                return panel.lblHeader.Text;
            }
            set
            {
                GetPropertyByName("_TextHeader").SetValue(panel, value);
            }
        }

        public bool _IsExpanded
        {
            get
            {
                return panel.IsExpanded;
            }
            set
            {
                GetPropertyByName("_IsExpanded").SetValue(panel, value);
            }
        }

        public bool _AllowExpand
        {
            get
            {
                return panel.AllowExpand;
            }
            set
            {
                GetPropertyByName("_AllowExpand").SetValue(panel, value);
            }
        }

        public Color _BackColorHeader
        {
            get
            {
                return panel.painel_header.BackColor;
            }
            set
            {
                GetPropertyByName("_BackColorHeader").SetValue(panel, value);
            }
        }

        public Image _ImgHeader
        {
            get
            {
                return panel.imgHeader.Image;
            }
            set
            {
                GetPropertyByName("_ImgHeader").SetValue(panel, value);
            }
        }

        // Implementation of this abstract method creates smart tag   
        // items, associates their targets, and collects into list. 
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));
            //items.Add(new DesignerActionHeaderItem("Information"));

            items.Add(new DesignerActionPropertyItem("_TextHeader",
                                                     "Text Header", "Appearance",
                                                     "Expand/collapse the panel."));

            items.Add(new DesignerActionPropertyItem("_IsExpanded",
                                                     "IsExpanded", "Appearance",
                                                     "Expand/collapse the panel."));

            items.Add(new DesignerActionPropertyItem("_AllowExpand",
                                                     "AllowExpand", "Appearance",
                                                     "Permiti Expandir ou Não"));

            items.Add(new DesignerActionPropertyItem("_BackColorHeader",
                                                     "BackColorHeader", "Appearance",
                                                     "Cor Header"));

            items.Add(new DesignerActionPropertyItem("_ImgHeader",
                                                     "Image Header", "Appearance",
                                                     "Image Header"));


            return items;
        }
    }

}
