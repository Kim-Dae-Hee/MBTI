using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    // 명시적으로 지정한 프로퍼티만 직렬화의 대상이 됨
    [MetadataType(typeof(PersonalityTypeMeta))]
    // ProsonalityType 클래스의 메타 정보가 PersonalityTypeMeta 클래스에 저장되어 있음
    public partial class PersonalityType
    {
        [JsonProperty]
        public int PersonalityTypeId { get; set; }
    }

    public class PersonalityTypeMeta
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Characteristic { get; set; }
    }
}
