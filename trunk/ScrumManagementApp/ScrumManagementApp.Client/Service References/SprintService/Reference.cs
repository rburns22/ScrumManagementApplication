﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScrumManagementApp.Client.SprintService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SprintService.ISprintService")]
    public interface ISprintService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/CreateSprint", ReplyAction="http://tempuri.org/ISprintService/CreateSprintResponse")]
        ScrumManagementApp.Common.DTOs.SprintDTO CreateSprint(ScrumManagementApp.Common.DTOs.SprintDTO sprint, int scrumMasterId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/CreateSprint", ReplyAction="http://tempuri.org/ISprintService/CreateSprintResponse")]
        System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.SprintDTO> CreateSprintAsync(ScrumManagementApp.Common.DTOs.SprintDTO sprint, int scrumMasterId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetSprintsForProject", ReplyAction="http://tempuri.org/ISprintService/GetSprintsForProjectResponse")]
        System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO> GetSprintsForProject(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetSprintsForProject", ReplyAction="http://tempuri.org/ISprintService/GetSprintsForProjectResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO>> GetSprintsForProjectAsync(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/AssignDeveloperToSprint", ReplyAction="http://tempuri.org/ISprintService/AssignDeveloperToSprintResponse")]
        void AssignDeveloperToSprint(ScrumManagementApp.Common.DTOs.SprintDTO sprintDTO, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/AssignDeveloperToSprint", ReplyAction="http://tempuri.org/ISprintService/AssignDeveloperToSprintResponse")]
        System.Threading.Tasks.Task AssignDeveloperToSprintAsync(ScrumManagementApp.Common.DTOs.SprintDTO sprintDTO, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetScrumManagerForSprint", ReplyAction="http://tempuri.org/ISprintService/GetScrumManagerForSprintResponse")]
        ScrumManagementApp.Common.DTOs.UserDTO GetScrumManagerForSprint(int sprintId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetScrumManagerForSprint", ReplyAction="http://tempuri.org/ISprintService/GetScrumManagerForSprintResponse")]
        System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.UserDTO> GetScrumManagerForSprintAsync(int sprintId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetDevelopersForSprint", ReplyAction="http://tempuri.org/ISprintService/GetDevelopersForSprintResponse")]
        System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserDTO> GetDevelopersForSprint(int sprintId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetDevelopersForSprint", ReplyAction="http://tempuri.org/ISprintService/GetDevelopersForSprintResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserDTO>> GetDevelopersForSprintAsync(int sprintId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetSprintsForUser", ReplyAction="http://tempuri.org/ISprintService/GetSprintsForUserResponse")]
        System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO> GetSprintsForUser(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintService/GetSprintsForUser", ReplyAction="http://tempuri.org/ISprintService/GetSprintsForUserResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO>> GetSprintsForUserAsync(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISprintServiceChannel : ScrumManagementApp.Client.SprintService.ISprintService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SprintServiceClient : System.ServiceModel.ClientBase<ScrumManagementApp.Client.SprintService.ISprintService>, ScrumManagementApp.Client.SprintService.ISprintService {
        
        public SprintServiceClient() {
        }
        
        public SprintServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SprintServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprintServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprintServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ScrumManagementApp.Common.DTOs.SprintDTO CreateSprint(ScrumManagementApp.Common.DTOs.SprintDTO sprint, int scrumMasterId) {
            return base.Channel.CreateSprint(sprint, scrumMasterId);
        }
        
        public System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.SprintDTO> CreateSprintAsync(ScrumManagementApp.Common.DTOs.SprintDTO sprint, int scrumMasterId) {
            return base.Channel.CreateSprintAsync(sprint, scrumMasterId);
        }
        
        public System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO> GetSprintsForProject(int projectId) {
            return base.Channel.GetSprintsForProject(projectId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO>> GetSprintsForProjectAsync(int projectId) {
            return base.Channel.GetSprintsForProjectAsync(projectId);
        }
        
        public void AssignDeveloperToSprint(ScrumManagementApp.Common.DTOs.SprintDTO sprintDTO, int userId) {
            base.Channel.AssignDeveloperToSprint(sprintDTO, userId);
        }
        
        public System.Threading.Tasks.Task AssignDeveloperToSprintAsync(ScrumManagementApp.Common.DTOs.SprintDTO sprintDTO, int userId) {
            return base.Channel.AssignDeveloperToSprintAsync(sprintDTO, userId);
        }
        
        public ScrumManagementApp.Common.DTOs.UserDTO GetScrumManagerForSprint(int sprintId) {
            return base.Channel.GetScrumManagerForSprint(sprintId);
        }
        
        public System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.UserDTO> GetScrumManagerForSprintAsync(int sprintId) {
            return base.Channel.GetScrumManagerForSprintAsync(sprintId);
        }
        
        public System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserDTO> GetDevelopersForSprint(int sprintId) {
            return base.Channel.GetDevelopersForSprint(sprintId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserDTO>> GetDevelopersForSprintAsync(int sprintId) {
            return base.Channel.GetDevelopersForSprintAsync(sprintId);
        }
        
        public System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO> GetSprintsForUser(int userId) {
            return base.Channel.GetSprintsForUser(userId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.SprintDTO>> GetSprintsForUserAsync(int userId) {
            return base.Channel.GetSprintsForUserAsync(userId);
        }
    }
}