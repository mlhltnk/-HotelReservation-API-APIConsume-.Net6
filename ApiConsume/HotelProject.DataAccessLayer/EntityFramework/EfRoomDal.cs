﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.Entity.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal : GenericRespository<Room>, IRoomDal
    {
        public EfRoomDal(HotelContext hotelContext) : base(hotelContext)
        {

        }

    }
}
