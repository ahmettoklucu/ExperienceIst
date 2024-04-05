﻿using ExperienceIst.Bussiness.Abstract;
using ExperienceIst.Bussiness.Concrate.FluentValidation;
using ExperienceIst.Bussiness.Concrate.ResultModele;
using ExperienceIst.Bussiness.Concrate.Utilities;
using ExperienceIst.DataAccess.Abstract;
using ExperienceIst.Entities.Concrate;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceIst.Bussiness.Concrate
{
    public class RequestManager : IRequestService
    {
        private readonly IRequestDal _requestDal;
        public RequestManager(IRequestDal requestDal)
        {
            _requestDal=requestDal;
        }

        ResultModel IRequestService.AddRequest(Request request)
        {

            ResultModel resultModele = new ResultModel();
            resultModele.Success = false;
            resultModele.Message = "";
            try
            {
                ValidationTool.Validate(new RequestValidator(), request);
                _requestDal.Add(request);
                resultModele.Message = "Your request is sent. We will be contacting you asp.";
                resultModele.Success = true;
            }
            catch (Exception ex)
            {
                resultModele.Message = ex.Message;
                resultModele.Success = false;

            }
            return resultModele;
        }
    }
}
