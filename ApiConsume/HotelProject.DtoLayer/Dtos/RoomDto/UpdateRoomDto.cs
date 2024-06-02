﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }


        [Required(ErrorMessage = "Lütfen oda no yazınız")]
        public int RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }


        [Required(ErrorMessage = "Lütfen fiyat giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı giriniz")]
        [StringLength(100,ErrorMessage = "lütfen en fazla 100 karakter veri girin")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }


        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }


        [Required(ErrorMessage = "Lütfen açıklama giriniz")]
        public string Description { get; set; }
    }
}
