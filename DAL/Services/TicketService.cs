using DAL.Repositories;
using Dapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
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

        public void AddTicket(Ticket ticket, int Id_User)
        {
            try
            {
                string procedure = "Ticket_Create";
                var parameter = new
                {
                    Title = ticket.Title,
                    Description = ticket.Title,
                    Attachment = ticket.Attachment,
                    TypeName = ticket.TicketType,
                    StartDate = ticket.StartDate,
                    Id_User = Id_User
                };

                connection.ExecuteScalar(procedure, parameter, commandType: CommandType.StoredProcedure);
            }
             catch(Exception e) 
            
            {
                throw new Exception(e.Message);
            }
           

                
        }

        public async Task<IEnumerable<TicketView>> GetAll()
        {
            string sql = "SELECT * FROM TicketView";

            return await connection.QueryAsync<TicketView>(sql);
        }

        public async Task<TicketView> GetById(int Id)
        {
            string sql = "Select * FROM TicketView WHERE Id = @Id";

            var param = new { Id = Id }; 
            return await connection.QueryFirstAsync<TicketView>(sql, param);
        }

 
    }
}
