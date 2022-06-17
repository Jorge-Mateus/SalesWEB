using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;
using SalesWebMVC.Services;
using SalesWebMVC.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly DepartmentService _departmentService;
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _departmentService = departmentService;
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete (int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!"});
            }

            var obj = _sellerService.FindbyId(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não existe!" }); 
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = _sellerService.FindbyId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não existe!" }); 
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }
            var obj = _sellerService.FindbyId(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não existe!" });
            }

            List<Department> departments = _departmentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };

            return View(viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller obj)
        {
            if(id != obj.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id diferentes!" });
            }
            try
            {
                _sellerService.Update(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {

                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }

    }
}
