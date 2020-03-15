using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressBookApp.Models
{
    public enum Prefectures 
    {
        北海道,
        青森県,
        岩手県,
        宮城県,
        秋田県,
        山形県,
        福島県,
        茨城県,
        栃木県,
        群馬県,
        埼玉県,
        千葉県,
        東京都,
        神奈川県,
        新潟県,
        富山県,
        石川県,
        福井県,
        山梨県,
        長野県,
        岐阜県,
        静岡県,
        愛知県,
        三重県,
        滋賀県,
        京都府,
        大阪府,
        兵庫県,
        奈良県,
        和歌山県,
        鳥取県,
        島根県,
        岡山県,
        広島県,
        山口県,
        徳島県,
        香川県,
        愛媛県,
        高知県,
        福岡県,
        佐賀県,
        長崎県,
        熊本県,
        大分県,
        宮崎県,
        鹿児島県,
        沖縄県
    }


    //partialより、ｸﾗｽ・構造体・ﾒｿｯﾄﾞ　複数のソースファイルで分割できる
    [MetadataType(typeof(AddressMetadata))]
    public partial class Address 
    {
        [DisplayName("都道府県")]
        public Prefectures? PrefectureItem { get; set; }    //?よりnullable型になるので初期状態になる

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
        [RegularExpression(@"[ァ-ヶ]+")]  //C#はRegularExpressionに正規表現を定義することで入力制限可能
        public string Kana { get; set; }

        [DisplayName("郵便番号")]
        [RegularExpression(@"[0-9]+")]
        [StringLength(7)]                 //桁数の制限
        public string ZipCode { get; set; }

        [DisplayName("都道府県")]
        public string Prefecture { get; set; }

        [DisplayName("住所")]
        public string StreetAddress { get; set; }

        [DisplayName("電話番号")]
        [RegularExpression(@"[0-9]+")]
        [StringLength(11)]
        public string Telephone { get; set; }

        [DisplayName("メール")]
        [DataType(DataType.EmailAddress)]   //C#は正規表現で書くと煩雑になるのでDataTypeよりEmailAddressを設定するほうが楽
        public string Mail { get; set; }

        [DisplayName("グループ")]
        public Nullable<int> Group_Id { get; set; }
    }
}