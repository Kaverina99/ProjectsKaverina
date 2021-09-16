using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IOtchetsRepository
    {
        List<OtchetProspochka> Otchet2(DateTime date);
        List<OtchetTipov> Otchet1(int tip);
    }
}