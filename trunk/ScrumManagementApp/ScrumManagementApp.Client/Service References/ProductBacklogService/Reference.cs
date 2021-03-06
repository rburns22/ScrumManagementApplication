﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScrumManagementApp.Client.ProductBacklogService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductBacklogService.IProductBacklogService")]
    public interface IProductBacklogService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/GetProductBacklogByProjectId", ReplyAction="http://tempuri.org/IProductBacklogService/GetProductBacklogByProjectIdResponse")]
        ScrumManagementApp.Common.DTOs.ProductBacklogDTO GetProductBacklogByProjectId(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/GetProductBacklogByProjectId", ReplyAction="http://tempuri.org/IProductBacklogService/GetProductBacklogByProjectIdResponse")]
        System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.ProductBacklogDTO> GetProductBacklogByProjectIdAsync(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/AddUserStoryToProjectBacklog", ReplyAction="http://tempuri.org/IProductBacklogService/AddUserStoryToProjectBacklogResponse")]
        void AddUserStoryToProjectBacklog(int projectID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/AddUserStoryToProjectBacklog", ReplyAction="http://tempuri.org/IProductBacklogService/AddUserStoryToProjectBacklogResponse")]
        System.Threading.Tasks.Task AddUserStoryToProjectBacklogAsync(int projectID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/GetProductBacklogUserStories", ReplyAction="http://tempuri.org/IProductBacklogService/GetProductBacklogUserStoriesResponse")]
        System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO> GetProductBacklogUserStories(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/GetProductBacklogUserStories", ReplyAction="http://tempuri.org/IProductBacklogService/GetProductBacklogUserStoriesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO>> GetProductBacklogUserStoriesAsync(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/EditUserStory", ReplyAction="http://tempuri.org/IProductBacklogService/EditUserStoryResponse")]
        void EditUserStory(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/EditUserStory", ReplyAction="http://tempuri.org/IProductBacklogService/EditUserStoryResponse")]
        System.Threading.Tasks.Task EditUserStoryAsync(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/DeleteUserStory", ReplyAction="http://tempuri.org/IProductBacklogService/DeleteUserStoryResponse")]
        void DeleteUserStory(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/DeleteUserStory", ReplyAction="http://tempuri.org/IProductBacklogService/DeleteUserStoryResponse")]
        System.Threading.Tasks.Task DeleteUserStoryAsync(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/ReprioritiseUserStory", ReplyAction="http://tempuri.org/IProductBacklogService/ReprioritiseUserStoryResponse")]
        void ReprioritiseUserStory(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductBacklogService/ReprioritiseUserStory", ReplyAction="http://tempuri.org/IProductBacklogService/ReprioritiseUserStoryResponse")]
        System.Threading.Tasks.Task ReprioritiseUserStoryAsync(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductBacklogServiceChannel : ScrumManagementApp.Client.ProductBacklogService.IProductBacklogService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductBacklogServiceClient : System.ServiceModel.ClientBase<ScrumManagementApp.Client.ProductBacklogService.IProductBacklogService>, ScrumManagementApp.Client.ProductBacklogService.IProductBacklogService {
        
        public ProductBacklogServiceClient() {
        }
        
        public ProductBacklogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductBacklogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductBacklogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductBacklogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ScrumManagementApp.Common.DTOs.ProductBacklogDTO GetProductBacklogByProjectId(int projectId) {
            return base.Channel.GetProductBacklogByProjectId(projectId);
        }
        
        public System.Threading.Tasks.Task<ScrumManagementApp.Common.DTOs.ProductBacklogDTO> GetProductBacklogByProjectIdAsync(int projectId) {
            return base.Channel.GetProductBacklogByProjectIdAsync(projectId);
        }
        
        public void AddUserStoryToProjectBacklog(int projectID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.AddUserStoryToProjectBacklog(projectID, userStory);
        }
        
        public System.Threading.Tasks.Task AddUserStoryToProjectBacklogAsync(int projectID, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.AddUserStoryToProjectBacklogAsync(projectID, userStory);
        }
        
        public System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO> GetProductBacklogUserStories(int projectId) {
            return base.Channel.GetProductBacklogUserStories(projectId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ScrumManagementApp.Common.DTOs.UserStoryDTO>> GetProductBacklogUserStoriesAsync(int projectId) {
            return base.Channel.GetProductBacklogUserStoriesAsync(projectId);
        }
        
        public void EditUserStory(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.EditUserStory(projectId, userStory);
        }
        
        public System.Threading.Tasks.Task EditUserStoryAsync(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.EditUserStoryAsync(projectId, userStory);
        }
        
        public void DeleteUserStory(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.DeleteUserStory(projectId, userStory);
        }
        
        public System.Threading.Tasks.Task DeleteUserStoryAsync(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.DeleteUserStoryAsync(projectId, userStory);
        }
        
        public void ReprioritiseUserStory(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            base.Channel.ReprioritiseUserStory(projectId, userStory);
        }
        
        public System.Threading.Tasks.Task ReprioritiseUserStoryAsync(int projectId, ScrumManagementApp.Common.DTOs.UserStoryDTO userStory) {
            return base.Channel.ReprioritiseUserStoryAsync(projectId, userStory);
        }
    }
}
