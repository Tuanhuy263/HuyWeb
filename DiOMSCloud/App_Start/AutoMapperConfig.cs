using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace DiOMSCloud
{
    public class AutoMapperConfig
    {
        private static AutoMapper.IMapper Mapping;

        public static IMapper Mapper
        {
            get { return Mapping; }
        }
         
        public static void RegisterMapping()
        {
            var mapperConfig = new AutoMapper.MapperConfiguration(config =>
            {
                config.CreateMap<DiOMSEntity.DIS_SOHeader, DiOMSCloud.Areas.Demand.Models.SOModelView>()
                      //.ForMember(dest => dest.ID, opt => opt.MapFrom(so => so.SONo))
                      .ForMember(dest => dest.Note, opt => opt.MapFrom(so => so.Note))
                      .ForMember(dest => dest.SONumber, opt => opt.MapFrom(so => so.SONumber));

                config.CreateMap<DiOMSEntity.DIS_SOHeader, SOListView>().ForMember(dest => dest.SONo, opt => opt.MapFrom(so => so.SONo))
                      .ForMember(dest => dest.SONumber, opt => opt.MapFrom(so => so.SONumber))
                      .ForMember(dest => dest.SOOriginalNumber, opt => opt.MapFrom(so => so.SOOriginalNumber))
                      .ForMember(dest => dest.HubCode, opt => opt.MapFrom(so => so.DIS_Hub.HubCode))
                      .ForMember(dest => dest.SODate, opt => opt.MapFrom(so => so.SODate))
                      .ForMember(dest => dest.HasASN, opt => opt.MapFrom((so, vw) =>
                      {
                          if (so.DIS_ASNSO != null && so.DIS_ASNSO.Count > 0)
                              return true;
                          return false;
                      }))
                      .ForMember(dest => dest.HasPO, opt => opt.MapFrom((so, vw) =>
                      {
                          if (so.DIS_POHeader != null)
                              return true;
                          return false;
                      }))
                      .ForMember(dest => dest.BOLNo, opt => opt.MapFrom((so, vw) =>
                      {
                          if (so.DIS_ASNSO != null && so.DIS_ASNSO.Count > 0)
                          {
                              foreach (var asnso in so.DIS_ASNSO)
                              {
                                  return asnso.DIS_ASN.BolNumber;
                              }
                          }
                          return string.Empty;
                      }))
                      .ForMember(dest => dest.PaymentDue, opt => opt.MapFrom(so => so.TotalPaymentDue))
                      .ForMember(dest => dest.Note, opt => opt.MapFrom(so => so.Note))
                      .ForMember(dest => dest.Status, opt => opt.MapFrom((so, vw)=>
                      {
                          string val = string.Empty;
                          switch (so.Status)
                          {
                              case (byte)Enums.SOStatus.FULFILLED:
                                  val = "Fulfilled" ; break;
                              case (byte)Enums.SOStatus.PARTIALLY:
                                  val = "Partial"; break;
                              case (byte)Enums.SOStatus.CANCEL:
                                  val = "Cancelled"; break;
                              case (byte)Enums.SOStatus.CLOSE:
                                  val = "Closed"; break;
                              default:
                                  val = "New";break;
                          }
                          return val;
                      }));

                config.CreateMap<DiOMSEntity.DIS_SODetail, SODetailView>().ForMember(dest => dest.ERPItemCode, opt => opt.MapFrom(so => so.DIS_MasterItem1.ERPItemCode))
                      .ForMember(dest => dest.Description, opt => opt.MapFrom(so => so.DIS_MasterItem1.Description))
                      .ForMember(dest => dest.Quantity, opt => opt.MapFrom(so => so.Quantity))
                      .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(so => so.UnitPrice))
                      .ForMember(dest => dest.UnitOfMeasureCode, opt => opt.MapFrom(so => so.DIS_UnitOfMeasure.UnitOfMeasureCode))
                      .ForMember(dest => dest.SONo, opt => opt.MapFrom(so => so.SONo))
                      .ForMember(dest => dest.Amount, opt => opt.MapFrom(so => so.Amount))
                      ;

                config.CreateMap<DiOMSEntity.DIS_POHeader, POListView>().ForMember(dest => dest.PONo, opt => opt.MapFrom(so => so.PONo))
                      .ForMember(dest => dest.PONumber, opt => opt.MapFrom(so => so.PONumber))
                      .ForMember(dest => dest.POOriginalNumber, opt => opt.MapFrom(so => so.POOriginalNumber))
                      .ForMember(dest => dest.VENDOR_NO, opt => opt.MapFrom(so => so.DIS_Vendor.VENDOR_NO))
                      .ForMember(dest => dest.PODate, opt => opt.MapFrom(so => so.PODate))
                      .ForMember(dest => dest.PaymentDue, opt => opt.MapFrom(so => so.TotalPaymentDue))
                      .ForMember(dest => dest.Note, opt => opt.MapFrom(so => so.Note))
                      .ForMember(dest => dest.SONumber, opt => opt.MapFrom(so => so.DIS_SOHeader.SONumber))
                      .ForMember(dest => dest.Status, opt => opt.MapFrom((so, vw) =>
                      {
                          string val = string.Empty;
                          switch (so.Status)
                          {
                              case (byte)Enums.POStatus.FULFILLED:
                                  val = "Fulfilled"; break;
                              case (byte)Enums.POStatus.PARTIALLY:
                                  val = "Partial"; break;
                              case (byte)Enums.POStatus.CANCEL:
                                  val = "Cancelled"; break;
                              case (byte)Enums.POStatus.CLOSE:
                                  val = "Closed"; break;
                              default:
                                  val = "New"; break;
                          }
                          return val;
                      })); 

                config.CreateMap<DiOMSEntity.DIS_POHeader, DiOMSCloud.Areas.Supply.Models.POModelView>()
                //.ForMember(dest => dest.ID, opt => opt.MapFrom(po => po.PONo))
                      .ForMember(dest => dest.Note, opt => opt.MapFrom(po => po.Note))
                      .ForMember(dest => dest.PONumber, opt => opt.MapFrom(po => po.PONumber));

                config.CreateMap<DiOMSEntity.DIS_PODetail, PODetailView>().ForMember(dest => dest.ERPItemCode, opt => opt.MapFrom(so => so.DIS_MasterItem.ERPItemCode))
                      .ForMember(dest => dest.Description, opt => opt.MapFrom(so => so.DIS_MasterItem.Description))
                      .ForMember(dest => dest.Quantity, opt => opt.MapFrom(so => so.Qty))
                      .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(so => so.UnitPrice))
                      .ForMember(dest => dest.UnitOfMeasureCode, opt => opt.MapFrom(so => so.DIS_UnitOfMeasure.UnitOfMeasureCode))
                      .ForMember(dest => dest.Amount, opt => opt.MapFrom(so => so.Amount));
            });
            Mapping = mapperConfig.CreateMapper();
        }


    }
}