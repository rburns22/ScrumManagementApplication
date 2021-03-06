﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScrumManagementApp.Client.SprintBacklogService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SprintBacklogService.ISprintBacklogService")]
    public interface ISprintBacklogService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/GetSprintBacklogById", ReplyAction="http://tempuri.org/ISprintBacklogService/GetSprintBacklogByIdResponse")]
        ScrumManagementApp.Common.DTOs.SprintBacklogDTO GetSprintBacklogById(int SprintBacklogID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/GetSprintBacklogById", ReplyAction="http://tempuri.org/ISprintBacklogService/GetSprintBacklogByIdResponse")]
        System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.SprintBacklogDTO> GetSprintBacklogByIdAsync(int SprintBacklogID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/AddUserStoryToSprintBacklog", ReplyAction="http://tempuri.org/ISprintBacklogService/AddUserStoryToSprintBacklogResponse")]
        void AddUserStoryToSprintBacklog(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/AddUserStoryToSprintBacklog", ReplyAction="http://tempuri.org/ISprintBacklogService/AddUserStoryToSprintBacklogResponse")]
        System.Threading.Tasks.Task AddUserStoryToSprintBacklogAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/GetSprintBacklogUserStories", ReplyAction="http://tempuri.org/ISprintBacklogService/GetSprintBacklogUserStoriesResponse")]
        System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO> GetSprintBacklogUserStories(int SprintBacklogID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/GetSprintBacklogUserStories", ReplyAction="http://tempuri.org/ISprintBacklogService/GetSprintBacklogUserStoriesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO>> GetSprintBacklogUserStoriesAsync(int SprintBacklogID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/EditUserStory", ReplyAction="http://tempuri.org/ISprintBacklogService/EditUserStoryResponse")]
        void EditUserStory(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/EditUserStory", ReplyAction="http://tempuri.org/ISprintBacklogService/EditUserStoryResponse")]
        System.Threading.Tasks.Task EditUserStoryAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/DeleteUserStory", ReplyAction="http://tempuri.org/ISprintBacklogService/DeleteUserStoryResponse")]
        void DeleteUserStory(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/DeleteUserStory", ReplyAction="http://tempuri.org/ISprintBacklogService/DeleteUserStoryResponse")]
        System.Threading.Tasks.Task DeleteUserStoryAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/ReprioritiseUserStory", ReplyAction="http://tempuri.org/ISprintBacklogService/ReprioritiseUserStoryResponse")]
        void ReprioritiseUserStory(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintBacklogService/ReprioritiseUserStory", ReplyAction="http://tempuri.org/ISprintBacklogService/ReprioritiseUserStoryResponse")]
        System.Threading.Tasks.Task ReprioritiseUserStoryAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISprintBacklogServiceChannel : ScrumManagementApp.Client.SprintBacklogService.ISprintBacklogService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SprintBacklogServiceClient : System.ServiceModel.ClientBase<ScrumManagementApp.Client.SprintBacklogService.ISprintBacklogService>, ScrumManagementApp.Client.SprintBacklogService.ISprintBacklogService {
        
        public SprintBacklogServiceClient() {
        }
        
        public SprintBacklogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SprintBacklogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprintBacklogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprintBacklogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ScrumManagementApp.Common.DTOs.SprintBacklogDTO GetSprintBacklogById(int SprintBacklogID) {
            return base.Channel.GetSprintBacklogById(SprintBacklogID);
        }
        
        public System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.SprintBacklogDTO> GetSprintBacklogByIdAsync(int SprintBacklogID) {
            return base.Channel.GetSprintBacklogByIdAsync(SprintBacklogID);
        }
        
        public void AddUserStoryToSprintBacklog(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.AddUserStoryToSprintBacklog(SprintBacklogID, userStory);
        }
        
        public System.Threading.Tasks.Task AddUserStoryToSprintBacklogAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.AddUserStoryToSprintBacklogAsync(SprintBacklogID, userStory);
        }
        
        public System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO> GetSprintBacklogUserStories(int SprintBacklogID) {
            return base.Channel.GetSprintBacklogUserStories(SprintBacklogID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO>> GetSprintBacklogUserStoriesAsync(int SprintBacklogID) {
            return base.Channel.GetSprintBacklogUserStoriesAsync(SprintBacklogID);
        }
        
        public void EditUserStory(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.EditUserStory(SprintBacklogID, userStory);
        }
        
        public System.Threading.Tasks.Task EditUserStoryAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.EditUserStoryAsync(SprintBacklogID, userStory);
        }
        
        public void DeleteUserStory(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.DeleteUserStory(SprintBacklogID, userStory);
        }
        
        public System.Threading.Tasks.Task DeleteUserStoryAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.DeleteUserStoryAsync(SprintBacklogID, userStory);
        }
        
        public void ReprioritiseUserStory(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.ReprioritiseUserStory(SprintBacklogID, userStory);
        }
        
        public System.Threading.Tasks.Task ReprioritiseUserStoryAsync(int SprintBacklogID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.ReprioritiseUserStoryAsync(SprintBacklogID, userStory);
        }
    }
}
