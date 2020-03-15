using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressBookApp.Models
{
    //partialより、ｸﾗｽ・構造体・ﾒｿｯﾄﾞ　複数のソースファイルで分割できる
    [MetadataType(typeof(AddressMetadata))]
    public partial class Address 
    {

    }

    public class AddressMetadata
    {
        //AddressBookModelと一致するﾌﾟﾛﾊﾟﾃｨと一致しているものを操作できる
        //DBファーストの開発ではMetadataｸﾗｽより操作する必要がある
        [Required]
        [DisplayName("氏名")]
        public string Name { get; set; }

        [Required]
        [DisplayName("カナ")]
        public string Kana { get; set; }

        [DisplayName("郵便番号")]
        public string ZipCode { get; set; }

        [DisplayName("都道府県")]
        public string Prefecture { get; set; }

        [DisplayName("住所")]
        public string StreetAddress { get; set; }

        [DisplayName("電話番号")]
        public string Telephone { get; set; }

        [DisplayName("メール")]
        public string Mail { get; set; }

        [DisplayName("グループ")]
        public Nullable<int> Group_Id { get; set; }
    }
}