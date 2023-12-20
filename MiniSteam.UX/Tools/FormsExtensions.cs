using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.UX.Tools
{
    public static class FormsExtensions
    {
        public static void LoadData<T>(this ComboBox cb, T datasource, string displayName="Name",string ValueMember="Id")
        {
            if (datasource != null)
            {
                cb.DataSource = datasource;
                cb.DisplayMember = displayName;
                cb.ValueMember = ValueMember;
            }
        }
    }
}
