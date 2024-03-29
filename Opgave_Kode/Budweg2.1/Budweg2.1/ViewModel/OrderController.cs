﻿using Budweg2._1.Model;
using Budweg2._1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg2._1.ViewModel
{
    public class OrderController
    {
        OrderRepository orderRepository = new OrderRepository();
        public List<Order> RetrieveAllOrders()
        {

            orderRepository.Load();
            List<Order> orders = orderRepository.GetOrders();
            return orders;
        }

        public void CreateOrder(int employeeId, string caliberType, int numberOfCalibers, string comment)
        {
            orderRepository.CreateOrder(employeeId, caliberType, numberOfCalibers, comment);
            orderRepository.Save();
        }

        public void DeleteOrder(int id)
        {
            orderRepository.DeleteOrder(id);
        }

        //public void UpdateOrder(int id, int choice, int newData)
        //{
        //    if (choice > 0 && choice < 2)
        //    {
        //        switch (choice)
        //        {
        //            case 1:
        //                GetOrderById(id).NumberOfCalibers = newData;
        //                break;
        //            case 2:
        //                GetOrderById(id).EmployeeId = newData;
        //                break;
        //        }

        //    }
        //}
        //public void UpdateOrder(int id, string newData)
        //{
        //    GetOrderById(id).Comment = newData;
        //}

        //public void UpdateOrder(int id, Employee emp)
        //{
        //    GetOrderById(id).Owner = emp;
        //}
    }
}
