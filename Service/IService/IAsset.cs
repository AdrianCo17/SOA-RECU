﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IAsset
    {
        List<Activo> GetAssets();
        int CreateAssets(Activo activo);
    }
}
