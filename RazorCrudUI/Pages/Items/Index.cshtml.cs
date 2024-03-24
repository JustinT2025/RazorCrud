﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrudUI.Data;
using RazorCrudUI.Models;

namespace RazorCrudUI.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly IItemRepository _repository;
        private object item;

        public IndexModel(IItemRepository repository)
        {
            _repository = repository;
        }

        public IList<ItemModel> ItemModel { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public async Task OnGetAsync()
        {
            
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                ItemModel = ItemModel.Where(s => s.Name.Contains(SearchString)).ToList();
            }

            ItemModel = (IList<ItemModel>)await _repository.GetItemsAsync(SearchString);
        }
    }
}