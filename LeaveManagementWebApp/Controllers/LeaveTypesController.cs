﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagementWebApp.Data;
using AutoMapper;
using LeaveManagementWebApp.Models;
using LeaveManagementWebApp.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagementWebApp.Constants;

namespace LeaveManagementWebApp.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        private readonly IMapper mapper;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var LeaveTypes = mapper.Map<List<LeaveTypesVM>>(await leaveTypeRepository.GetAllAsync());
            return View(LeaveTypes);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVm = mapper.Map<LeaveTypesVM>(leaveType);
            return View(leaveTypeVm);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypesVM leaveTypeVm)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVm);
                await leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVm);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVm = mapper.Map<LeaveTypesVM>(leaveType);
            return View(leaveTypeVm);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypesVM leaveTypeVm)
        {
            if (id != leaveTypeVm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVm);
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVm);
        }

        // GET: LeaveTypes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.LeaveTypes == null)
        //    {
        //        return NotFound();
        //    }

        //    var leaveType = await _context.LeaveTypes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (leaveType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(leaveType);
        //}

        // POST: LeaveTypes/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
            await leaveAllocationRepository.LeaveAllocation(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
