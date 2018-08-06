using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class GoodMovementSelectionViewModel
    {
        public List<SelectGoodMovementEditorViewModel> GoodMovements { get; set; }
        public GoodMovementSelectionViewModel()
        {
            this.GoodMovements = new List<SelectGoodMovementEditorViewModel>();
        }
        public IEnumerable<int> getSelectedIds()
        {
            // Return an Enumerable containing the Id's of the selected people:
            return (from g in this.GoodMovements where g.Selected select g.ID).ToList();
        }
    }
}