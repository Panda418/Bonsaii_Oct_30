﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bonsaii.Models;

namespace Bonsaii.Controllers
{
    public class BillPropertyModelsController : BaseController
    {
        // GET: BillPropertyModels
        public ActionResult Index()
        {
            return View(base.db.BillProperties.ToList());
        }

        // GET: BillPropertyModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillPropertyModels billPropertyModels = db.BillProperties.Find(id);
            if (billPropertyModels == null)
            {
                return HttpNotFound();
            }
            return View(billPropertyModels);
        }

        // GET: BillPropertyModels/Create
        public ActionResult Create()
        {
            List<CodeMethod> list = CodeMethod.GetCodeMethod();
            List<SelectListItem> item = list.Select(c => new SelectListItem
            {
                Value = c.Id,
                Text = c.Description
            }).ToList();

            ViewBag.List = item;
            return View();
        }
        // POST: BillPropertyModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BillPropertyModels billPropertyModels)
        {
            if (ModelState.IsValid)
            {
                switch (billPropertyModels.CodeMethod)
                {
                    case CodeMethod.Two:
                        billPropertyModels.Year = 4;
                        billPropertyModels.Month = 2;
                        billPropertyModels.Day = 0;
                        billPropertyModels.SerialNumber = 4;
                        break;
                    case CodeMethod.Three:
                        billPropertyModels.Year = 0;
                        billPropertyModels.Month = 0;
                        billPropertyModels.Day = 0;
                        billPropertyModels.SerialNumber = this.GetSerialNumbers(billPropertyModels.Code);
                        break;
                    case CodeMethod.Four:
                        billPropertyModels.Year = 0;
                        billPropertyModels.Month = 0;
                        billPropertyModels.Day = 0;
                        billPropertyModels.SerialNumber = 0;
                        break;
                    default:
                        billPropertyModels.Year = 4;
                        billPropertyModels.Month = 2;
                        billPropertyModels.Day = 2;
                        billPropertyModels.SerialNumber = 2;
                        break;
                }
                db.BillProperties.Add(billPropertyModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(billPropertyModels);
        }

        // GET: BillPropertyModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillPropertyModels billPropertyModels = db.BillProperties.Find(id);
            if (billPropertyModels == null)
            {
                return HttpNotFound();
            }
            List<CodeMethod> list = CodeMethod.GetCodeMethod();
            List<SelectListItem> item = list.Select(c => new SelectListItem
            {
                Value = c.Id,
                Text = c.Description
            }).ToList();
            foreach (var tmp in item)
            {
                if (billPropertyModels.CodeMethod == tmp.Text)
                {
                    tmp.Selected = true;
                    break;
                }
            }
            ViewBag.List = item;
            return View(billPropertyModels);
        }

        // POST: BillPropertyModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,TypeName,TypeFullName,CodeMethod,Year,Month,Day,SerialNumber,Code,IsAutoAudit,IsApprove,IsLimitInput,IsAscOrDesc")] BillPropertyModels billPropertyModels)
        {
            if (ModelState.IsValid)
            {
                switch (billPropertyModels.CodeMethod)
                {
                    case CodeMethod.Two:
                        billPropertyModels.Year = 4;
                        billPropertyModels.Month = 2;
                        billPropertyModels.Day = 0;
                        billPropertyModels.SerialNumber = 4;
                        break;
                    case CodeMethod.Three:
                        billPropertyModels.Year = 0;
                        billPropertyModels.Month = 0;
                        billPropertyModels.Day = 0;
                        billPropertyModels.SerialNumber = this.GetSerialNumbers(billPropertyModels.Code);
                        break;
                    case CodeMethod.Four:
                        billPropertyModels.Year = 0;
                        billPropertyModels.Month = 0;
                        billPropertyModels.Day = 0;
                        billPropertyModels.SerialNumber = 0;
                        break;
                    default:
                        billPropertyModels.Year = 4;
                        billPropertyModels.Month = 2;
                        billPropertyModels.Day = 2;
                        billPropertyModels.SerialNumber = 2;
                        break;
                }
                db.Entry(billPropertyModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(billPropertyModels);
        }

        // GET: BillPropertyModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillPropertyModels billPropertyModels = db.BillProperties.Find(id);
            if (billPropertyModels == null)
            {
                return HttpNotFound();
            }
            return View(billPropertyModels);
        }

        // POST: BillPropertyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BillPropertyModels billPropertyModels = db.BillProperties.Find(id);
            db.BillProperties.Remove(billPropertyModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        /// <summary>
        /// 如果是纯流水号的编码方式，返回流水号的位数（因为可能包含一定的英文字符前缀 )
        /// </summary>
        /// <param name="str"></param>
        /// <returns>返回实际的流水号位数</returns>
        public int GetSerialNumbers(string str)
        {
            return 10 - str.IndexOf('*', 0, 10);
        }
        public JsonResult CheckType(string Type)
        {
            int bill = db.BillProperties.Where(p => p.Type == Type).Count();
            if (bill != 0)
                return Json(new { result = "ERROR", });
            else
                return Json(new { result = "OK", });
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }



        /// <summary>
        /// 根据单据类型编号，生成单号
        /// </summary>
        /// <param name="BillTypeNumber">单据类型编号</param>
        /// <returns>单号</returns>
        public string GenerateBillNumber(string BillTypeNumber)
        {
            BillPropertyModels tmp = db.BillProperties.Where(p => p.Type == BillTypeNumber).Single();
            string date = DateTime.Now.ToString("yyyyMMdd");
            //为流水号补充零
            string SerialNumber = AddZero(tmp.Count, tmp.SerialNumber);
            //更新单号的计数值
            tmp.Count++;
            db.Entry(tmp).State = EntityState.Modified;
            db.SaveChanges();

            switch (tmp.CodeMethod)
            {
                case CodeMethod.One:
                    return DateTime.Now.ToString("yyyyMMdd").ToString() + SerialNumber;
                case CodeMethod.Two:
                    return DateTime.Now.ToString("yyyyMM").ToString() + SerialNumber;
                case CodeMethod.Three:
                    return tmp.Code.Substring(0, 10 - tmp.SerialNumber) + SerialNumber;
                default:
                    return "";
            }
        }

        /// <summary>
        /// 将SerialNumber补零凑够length长度的数值
        /// </summary>
        /// <param name="SerialNumber"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public string AddZero(int SerialNumber, int length)
        {
            string tmp = SerialNumber.ToString();
            while (tmp.Length != length)
                tmp = tmp.Insert(0, "0");
            return tmp;
        }


        public ActionResult Test()
        {
            //           string name = this.GenerateBillNumber("0009");
            return View();
        }
        [HttpPost]
        public ActionResult Test(string Number)
        {
            ViewBag.num = this.GenerateBillNumber(Number);
            return View("Show");
        }
    }
}
