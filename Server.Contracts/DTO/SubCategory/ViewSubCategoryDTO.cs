﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Contracts.DTO.SubCategory
{
    public class ViewSubCategoryDTO
    {
        public required string SubId { get; set; }
        public string? SubName { get; set; }
        public required int Status { get; set; }
        public required Guid CategoryId { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
