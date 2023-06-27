using DAL.Repositories;
using Dapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class TicketService : ITicketRepository
    {
        private readonly IDbConnection connection;

        public TicketService(IDbConnection connection)
        {
            this.connection = connection;
        }

        public void AddTicket(Ticket ticket)
        {
            string sql = "Insert INTO Ticket (Title, Description, Attachment, TicketType)"  +
                " VALUES (@Title, @Description,@Attachment, @TicketType)"; 

            connection.Execute(sql, ticket);
                
        }

        public async Task<IEnumerable<Ticket>> GetAll()
        {
            string sql = "SELECT * FROM Tickets";

            return await connection.QueryAsync<Ticket>(sql);
        }

        public async Task<Ticket> GetById(int Id)
        {
            string sql = "Select * FROM Ticket WHERE Id = @Id";

            var param = new { Id = Id }; 
            return await connection.QueryFirstAsync<Ticket>(sql, param);
        }

 
    }
}
