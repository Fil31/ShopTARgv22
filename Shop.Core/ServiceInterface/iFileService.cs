﻿using Shop.Core.Domain;
using Shop.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ServiceInterface
{
    public interface iFileService
    {
        void FilesToApi(SpaceshipDto dto, Spaceship spaceship);
    }
}
