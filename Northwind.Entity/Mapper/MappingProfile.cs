using AutoMapper;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Customers Profile 
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<CustomerCustomerDemo, DtoCustomerCustomerDemo>().ReverseMap();
            CreateMap<CustomerDemographic, DtoCustomerDemographic>().ReverseMap();
            CreateMap<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>().ReverseMap();

            //Supliers Profile
            CreateMap<Supplier, DtoSupplier>().ReverseMap();

            //Territories Profile
            CreateMap<Territory, DtoTerritory>().ReverseMap();

            //Employees Profile
            CreateMap<Employee, DtoEmployee>().ReverseMap();
            CreateMap<EmployeeTerritory, DtoEmployeeTerritory>().ReverseMap();

            //Orders Profile
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();
            CreateMap<OrderDetailsExtended, DtoOrderDetailsExtended>().ReverseMap();
            CreateMap<OrdersQry, DtoOrdersQry>().ReverseMap();
            CreateMap<OrderSubtotal, DtoOrderSubTotal>().ReverseMap();
            CreateMap<QuarterlyOrder, DtoQuarterlyOrder>().ReverseMap();

            //Products Profile
            CreateMap<Product, DtoProduct>().ReverseMap();
            CreateMap<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>().ReverseMap();
            CreateMap<ProductsByCategory, DtoProductsByCategory>().ReverseMap();
            CreateMap<CurrentProductList, DtoCurrentProductList>().ReverseMap();
            CreateMap<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>().ReverseMap();

            //Regions Profile
            CreateMap<Region, DtoRegion>().ReverseMap();

            //Shippers Profile
            CreateMap<Shipper, DtoShipper>().ReverseMap();

            //Users Profile
            CreateMap<User, DtoUser>().ReverseMap();

            //Categories Profile 
            CreateMap<Category, DtoCategory>().ReverseMap();

            //Sales Profile
            CreateMap<CategorySalesFor1997, DtoCategorySalesFor1997>().ReverseMap();
            CreateMap<SalesByCategory, DtoSalesByCategory>().ReverseMap();
            CreateMap<SalesTotalsByAmount, DtoSalesTotalsByAmount>().ReverseMap();
            CreateMap<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>().ReverseMap();
            CreateMap<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>().ReverseMap();
            CreateMap<ProductSalesFor1997, DtoProductSalesFor1997>().ReverseMap();

            //Invoices Profile
            CreateMap<Invoice, DtoInvoice>().ReverseMap();















        }
    }
}
