﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.Admin.AdminShopService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminShopService.IAdminServiceOnlineShop")]
    public interface IAdminServiceOnlineShop {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminServiceOnlineShop/LoadDataService", ReplyAction="http://tempuri.org/IAdminServiceOnlineShop/LoadDataServiceResponse")]
        string LoadDataService(string price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminServiceOnlineShop/LoadDataService", ReplyAction="http://tempuri.org/IAdminServiceOnlineShop/LoadDataServiceResponse")]
        System.Threading.Tasks.Task<string> LoadDataServiceAsync(string price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminServiceOnlineShop/BrendsForAdmin", ReplyAction="http://tempuri.org/IAdminServiceOnlineShop/BrendsForAdminResponse")]
        string BrendsForAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminServiceOnlineShop/BrendsForAdmin", ReplyAction="http://tempuri.org/IAdminServiceOnlineShop/BrendsForAdminResponse")]
        System.Threading.Tasks.Task<string> BrendsForAdminAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminServiceOnlineShop/AssortmentForAdmin", ReplyAction="http://tempuri.org/IAdminServiceOnlineShop/AssortmentForAdminResponse")]
        string AssortmentForAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminServiceOnlineShop/AssortmentForAdmin", ReplyAction="http://tempuri.org/IAdminServiceOnlineShop/AssortmentForAdminResponse")]
        System.Threading.Tasks.Task<string> AssortmentForAdminAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceOnlineShopChannel : OnlineShop.Admin.AdminShopService.IAdminServiceOnlineShop, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceOnlineShopClient : System.ServiceModel.ClientBase<OnlineShop.Admin.AdminShopService.IAdminServiceOnlineShop>, OnlineShop.Admin.AdminShopService.IAdminServiceOnlineShop {
        
        public AdminServiceOnlineShopClient() {
        }
        
        public AdminServiceOnlineShopClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminServiceOnlineShopClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceOnlineShopClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceOnlineShopClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string LoadDataService(string price) {
            return base.Channel.LoadDataService(price);
        }
        
        public System.Threading.Tasks.Task<string> LoadDataServiceAsync(string price) {
            return base.Channel.LoadDataServiceAsync(price);
        }
        
        public string BrendsForAdmin() {
            return base.Channel.BrendsForAdmin();
        }
        
        public System.Threading.Tasks.Task<string> BrendsForAdminAsync() {
            return base.Channel.BrendsForAdminAsync();
        }
        
        public string AssortmentForAdmin() {
            return base.Channel.AssortmentForAdmin();
        }
        
        public System.Threading.Tasks.Task<string> AssortmentForAdminAsync() {
            return base.Channel.AssortmentForAdminAsync();
        }
    }
}
