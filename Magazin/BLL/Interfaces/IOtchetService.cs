using BLL.Models.OtchetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IOtchetService
    {
        List<OtchetProspochka> Otchet2(DateTime date);
        List<OtchetTipov> Otchet1(int tip);
    }
}
