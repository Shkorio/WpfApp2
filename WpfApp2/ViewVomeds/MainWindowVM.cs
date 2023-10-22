using System.Collections.Generic;
using System.Linq;
using WpfApp2.BaseTools;
using WpfApp2.bd;

namespace WpfApp2.ViewVomeds
{
    public class MainWindowVM: Tools
    {
        public Magazine SelectedItem { get; set; }
        public Cm EditTowar { get; set; }
        public List<Magazine> Magazines { get => magazines; set { magazines = value; Signal(); } }
        user03Context context = new user03Context();
        private List<Magazine> magazines;

        public MainWindowVM()
        {
            Magazines = context.Magazines.ToList();
            EditTowar = new Cm(() =>
            {
                if(SelectedItem != null)
                {
                    context.Magazines.Remove(SelectedItem);
                    context.SaveChanges();
                    
                }
                Magazines = null;
                Magazines = context.Magazines.ToList();
            });
        }
         
    }
}
