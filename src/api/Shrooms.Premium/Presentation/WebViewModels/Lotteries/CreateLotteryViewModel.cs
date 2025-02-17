﻿using System;
using System.ComponentModel.DataAnnotations;
using Shrooms.Contracts.Constants;
using Shrooms.DataLayer.EntityModels.Models.Lottery;

namespace Shrooms.Premium.Presentation.WebViewModels.Lotteries
{
    public class CreateLotteryViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [StringLength(ValidationConstants.MaxPostMessageBodyLength)]
        public string Description { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int EntryFee { get; set; }
        [Required]
        public int Status { get; set; }
        public ImagesCollection Images { get; set; }
    }
}
