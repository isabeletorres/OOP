﻿using System;
using Enumeracoes.Entites.Enums;
namespace Enumeracoes.Entites
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                 + ", "
                 + Moment
                 + ", "
                 + Status;
        }
    }
}
