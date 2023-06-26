﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITicketRepository
    {
        public void AddTicket (Ticket ticket);
        Task <Ticket> GetById (int Id);
        Task <IEnumerable<Ticket>> GetAll();

    }
}
