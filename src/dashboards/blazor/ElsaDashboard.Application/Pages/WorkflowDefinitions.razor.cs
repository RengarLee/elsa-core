﻿using System.Threading.Tasks;
using Elsa.Client.Models;
using ElsaDashboard.Shared.Rpc;
using Microsoft.AspNetCore.Components;

namespace ElsaDashboard.Application.Pages
{
    partial class WorkflowDefinitions
    {
        [Inject] private IWorkflowDefinitionService WorkflowDefinitionService { get; set; } = default!;
        private PagedList<WorkflowDefinition> Definitions { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Definitions = await WorkflowDefinitionService.ListAsync();
        }
    }
}