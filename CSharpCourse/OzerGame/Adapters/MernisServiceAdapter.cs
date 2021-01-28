using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using OzerGame.Abstract;
using OzerGame.Entities;

namespace OzerGame.Adapters
{
    public class MernisServiceAdapter:IMemberCheckService
    {
        public bool CheckIfRealMember(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(member.NationalityId), member.FirstName.ToUpper(),
                    member.LastName.ToUpper(), member.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
