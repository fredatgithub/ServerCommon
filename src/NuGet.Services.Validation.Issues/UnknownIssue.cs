﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGet.Services.Validation.Issues
{
    /// <summary>
    /// A placeholder error when the specific error is unknown.
    /// </summary>
    public class UnknownIssue : ValidationIssue
    {
        public override ValidationIssueCode IssueCode => ValidationIssueCode.Unknown;

        public override string GetMessage() => "Package validation failed due to an unknown error.";
    }
}
