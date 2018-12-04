using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace mcdev_controls.c_Headers.Vertical
{
    /// <summary>
    /// DesignerActionList-derived class defines smart tag entries and resultant actions. 
    /// <remarks>http://msdn.microsoft.com/en-us/library/ms171829.aspx</remarks>
    /// </summary>
    public class ExpandVerticalCollapsePanelActionList : System.ComponentModel.Design.DesignerActionList
    {
        private mcExpandVerticalCollapsePanel panel;

        private DesignerActionUIService designerActionUISvc = null;

        //The constructor associates the control  
        //with the smart tag list. 
        public ExpandVerticalCollapsePanelActionList(IComponent component)
            : base(component)
        {
            this.panel = component as mcExpandVerticalCollapsePanel;

            // Cache a reference to DesignerActionUIService, so the 
            // DesigneractionList can be refreshed. 
            this.designerActionUISvc =
                GetService(typeof(DesignerActionUIService))
                as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of  
        // GetProperties enables undo and menu updates to work properly. 
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

        // Properties that are targets of DesignerActionPropertyItem entries. 
        public bool IsExpanded
        {
            get
            {
                return panel.IsExpanded;
            }
            set
            {
                GetPropertyByName("IsExpanded").SetValue(panel, value);
                // Refresh the list. 
                //this.designerActionUISvc.Refresh(this.Component);
            }
        }
        public bool _AllowExpand
        {
            get
            {
                return panel.allowExpand;
            }
            set
            {
                GetPropertyByName("_AllowExpand").SetValue(panel, value);
                // Refresh the list. 
                //this.designerActionUISvc.Refresh(this.Component);
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

            //Boolean property for locking color selections.
            items.Add(new DesignerActionPropertyItem("IsExpanded",
                                                     "IsExpanded", "Appearance",
                                                     "Expand/collapse the panel."));

            items.Add(new DesignerActionPropertyItem("_AllowExpand",
                                                     "AllowExpand", "Appearance",
                                                     "Permiti Expandir ou Não"));

            return items;
        }
    }
}