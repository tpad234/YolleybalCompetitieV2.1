﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public interface IGebruikerDal
    {
        List<DataRow> GetGebruikerByName(string username);
    }
}
