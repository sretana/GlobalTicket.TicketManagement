﻿using FluentValidation;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandValidator:AbstractValidator<CreateEventComman>
    {
        private readonly IEventRepository _eventRepository;

        public CreateEventCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Date)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .GreaterThan(DateTime.Now);

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .GreaterThan(0);

            RuleFor(e => e)
                .MustAsync(EventNameAndDateUnique)
                .WithMessage("An event with the same name and date already exists");

        }

        private async Task<bool> EventNameAndDateUnique(CreateEventComman arg1, CancellationToken arg2)
        {
            return !(await _eventRepository.IsEventNameAndDateUnique(arg1.Name, arg1.Date));
        }
    }
}