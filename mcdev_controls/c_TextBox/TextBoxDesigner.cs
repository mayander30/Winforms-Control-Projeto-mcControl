using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcdev_controls.C_TextBox
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class TextBoxDesigner : System.Windows.Forms.Design.ScrollableControlDesigner
    {
        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu. 
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(
                        new TextBoxDesignerActionList(this.Component));
                }
                return actionLists;
            }
        }
    }

    public class TextBoxDesignerActionList : System.ComponentModel.Design.DesignerActionList
    {
        private object textbox;

        private DesignerActionUIService designerActionUISvc = null;

        //The constructor associates the control  
        //with the smart tag list. 
        public TextBoxDesignerActionList(IComponent component)
            : base(component)
        {
            this.textbox = component as object;

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
            try
            {
                PropertyDescriptor prop;
                prop = TypeDescriptor.GetProperties(textbox)[propName];
                if (null == prop)
                    throw new ArgumentException(
                        "Matching ExpandCollapsePanel property not found!",
                        propName);
                else
                    return prop;
            }
            catch { return null; }
        }

        #region Propiedades de Configuração textbox

        public String Name
        {
            get
            {
                return (String)GetPropertyByName("Name").GetValue(textbox);
            }
            set
            {
                GetPropertyByName("Name").SetValue(textbox, value);
            }
        }
                
        public decimal _DECIMAIS_MOEDA
        {
            get
            {
                return (decimal)GetPropertyByName("_DECIMAIS_MOEDA").GetValue(textbox);
            }
            set
            {
                GetPropertyByName("_DECIMAIS_MOEDA").SetValue(textbox, value);
            }
        }

        public bool _SHOWSIMBOLO
        {
            get
            {
                return (bool)GetPropertyByName("_SHOWSIMBOLO").GetValue(textbox);
            }
            set
            {
                GetPropertyByName("_SHOWSIMBOLO").SetValue(textbox, value);
            }
        }

        public TipoFormato _FORMAT
        {
            get
            {
                return (TipoFormato)GetPropertyByName("_FORMAT").GetValue(textbox);
            }
            set
            {
                GetPropertyByName("_FORMAT").SetValue(textbox, value);
            }
        }

        #endregion

        // Implementation of this abstract method creates smart tag   
        // items, associates their targets, and collects into list. 
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Configurações TextBox"));
            //items.Add(new DesignerActionHeaderItem("Information"));

            items.Add(new DesignerActionPropertyItem("Name",
                                                     "Name", "Configurações textbox",
                                                     "Name do textbox"));

            if (textbox is mcdev_controls.C_TextBox.mcTextBox_DateTime)
            {
                items.Add(new DesignerActionPropertyItem("_FORMAT",
                                                     "_FORMAT", "Configurações textbox",
                                                     "Formato data ou hora do campo"));
            }

            if (textbox is mcdev_controls.C_TextBox.mcTextBox_Moeda)
            {
                items.Add(new DesignerActionPropertyItem("_DECIMAIS_MOEDA",
                                                     "_DECIMAIS_MOEDA", "Configurações textbox",
                                                     "Numero de decimais no campo."));

                items.Add(new DesignerActionPropertyItem("_SHOWSIMBOLO",
                                                     "_SHOWSIMBOLO", "Configurações textbox",
                                                     "Mostra moeda"));
            }           

            return items;
        }
    }
}
