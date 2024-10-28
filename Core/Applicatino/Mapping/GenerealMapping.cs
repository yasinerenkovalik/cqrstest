using System;
using Applicatino.Features.Commat.CreateProduct;
using AutoMapper;

namespace Applicatino.Mapping;

public class GenerealMapping:Profile
{
    public GenerealMapping()
    {
        CreateMap<Domain.Product,Dtos.ProductViewDto>().ReverseMap();
        CreateMap<Domain.Product,CreateProductCommand>().ReverseMap();
       
    }

}
