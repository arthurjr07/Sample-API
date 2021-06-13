// <copyright file="EmployeeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Sample.WebAPI.Model;

namespace Sample.WebAPI.Controllers
{
    /// <summary>
    /// This class is for add, edit, delete of employee records in the database.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult Get()
        {
            string selectSql = "SELECT * FROM [dbo].[Employee]";
            string connectionString = "server=(localdb)\\MSSQLLocalDB; database=DemoDb; trusted_connection=yes;";
            using (var connection = new SqlConnection(connectionString))
            {
                var employeeList = connection.Query<Employee>(selectSql).ToList();
                return Ok(employeeList);
            }
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            string selectSql = "SELECT * FROM [dbo].[Employee] WHERE EmployeeId = @EmployeeId";
            string connectionString = "server=(localdb)\\MSSQLLocalDB; database=DemoDb; trusted_connection=yes;";
            using (var connection = new SqlConnection(connectionString))
            {
                var employee = connection.QueryFirstOrDefault<Employee>(selectSql, new { EmployeeId = id });
                return Ok(employee);
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            string selectSql = "UPDATE[dbo].[Employee] SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate WHERE EmployeeId = @EmployeeId;";
            string connectionString = "server=(localdb)\\MSSQLLocalDB; database=DemoDb; trusted_connection=yes;";
            using (var connection = new SqlConnection(connectionString))
            {
                var affectedRows = connection.Execute(selectSql, new { EmployeeId = employee.EmployeeId, FirstName = employee.FirstName, LastName = employee.LastName, BirthDate = employee.BirthDate });
            }
        }

            // PUT api/<EmployeeController>/5
            [HttpPut]
        public void Put([FromBody] Employee employee)
        {
            string selectSql = "INSERT INTO [dbo].[Employee] (EmployeeId, FirstName, LastName, BirthDate) Values (@EmployeeId, @FirstName, @LastName, @BirthDate);";
            string connectionString = "server=(localdb)\\MSSQLLocalDB; database=DemoDb; trusted_connection=yes;";
            using (var connection = new SqlConnection(connectionString))
            {
                var affectedRows = connection.Execute(selectSql, new { EmployeeId = employee.EmployeeId, FirstName = employee.FirstName, LastName = employee.LastName, BirthDate = employee.BirthDate });
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{employeeId}")]
        public void Delete(string employeeId)
        {
            string selectSql = "DELETE [dbo].[Employee] WHERE EmployeeId = @EmployeeId;";
            string connectionString = "server=(localdb)\\MSSQLLocalDB; database=DemoDb; trusted_connection=yes;";
            using (var connection = new SqlConnection(connectionString))
            {
                var affectedRows = connection.Execute(selectSql, new { EmployeeId = employeeId });
            }
        }
    }
}
