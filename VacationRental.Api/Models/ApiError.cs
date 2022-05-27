﻿using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using VacationRental.Application.Notifications;

namespace VacationRental.Api.Models
{
    public class ApiError
    {
        public ApiError()
        {
        }

        public ApiError(IEnumerable<Notification> errors, ErrorCode? error = null)
        {
            this.ErrorType = error;
            this.Errors = errors;
        }

        public ErrorCode? ErrorType { get; private set; }
        public IEnumerable<Notification> Errors { get; private set; }

        public static ApiError FromResult(Result result)
        {
            return new ApiError(result.Notifications, result.Error);
        }
    }
}
