﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EApp.Core.DomainDriven.Events;

namespace EApp.Core.DomainDriven.Bus
{
    /// <summary>
    ///  The message bus.
    /// </summary>
    public interface IBus
    {
        Guid ID { get; }
        /// <summary>
        /// Publishes the specified message to the bus.
        /// </summary>
        /// <param name="message">The message to be published.</param>
        void Publish<TMessage>(TMessage message)
            where TMessage : class, IEvent;
        /// <summary>
        /// Publishes a collection of messages to the bus.
        /// </summary>
        /// <param name="messages">The messages to be published.</param>
        void Publish<TMessage>(IEnumerable<TMessage> messages)
            where TMessage : class, IEvent;
        /// <summary>
        /// Clears the published messages waiting for commit.
        /// </summary>
        void Clear();
    }
}
