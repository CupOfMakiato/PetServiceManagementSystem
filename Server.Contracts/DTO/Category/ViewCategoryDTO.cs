﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Contracts.DTO.Category
{
    public class ViewCategoryDTO
    {
        public ViewCategoryDTO()
        {
            SubCategories = new HashSet<ViewSubCateDTO>();
        }
        public string CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public int CategoryStatus { get; set; }
        public DateTime CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public DateTime? DeletionDate { get; set; }
        public ICollection<ViewSubCateDTO> SubCategories { get; set; }
    }
}
