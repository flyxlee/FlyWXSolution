using System;
using System.Text;

namespace WXService.Message
{
    public class PlanningCertificateMsg
    {
        public string GetAttentionMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("感谢您对鹤山市沙坪街道人口和计划生育服务中心的关注，我们将为您提供详尽的计生服务，");
            sb.Append("电话：0750-893013、0750-8930829，");
            sb.Append("地址：鹤山市沙坪街道新环路833号一楼办证大厅（松鹤新城后面）。");
            return sb.ToString();
        }

        public string GetDefaultMsg()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("欢迎您使用沙坪人口公众微信号，我们将竭诚为您服务，发送数字查询相关办事程序：").Append("\n");
            //sb.Append("1.办理一胎生育审核登记程序").Append("\n");
            //sb.Append("2.办理再生育审批登记程序").Append("\n");
            //sb.Append("3.领取《计划生育服务证》程序").Append("\n");
            //sb.Append("4.办理《独生子女父母光荣证》程序").Append("\n"); ;
            //sb.Append("5.未婚者办理《流动人口婚育证明》程序").Append("\n");
            //sb.Append("6.已婚者办理《流动人口婚育证明》程序").Append("\n");
            //sb.Append("7.办理户口、土地证、房产证、车辆年审、小孩入学等各类计生证明的程序").Append("\n"); ;
            //sb.Append("8.农村计划生育家庭奖励金申领程序").Append("\n");
            //sb.Append("9.农村计划生育节育奖励金申领程序").Append("\n");
            //sb.Append("a.城镇独生子女父母计划生育奖励金申领程序").Append("\n");
            //sb.Append("b.计划生育家庭特别扶助金申领程序").Append("\n");
            //sb.Append("c.外来流动人口办理户口、土地证、房产证、车辆年审、小孩入学等各类计生证明的程序").Append("\n");
            //sb.Append("d.办理《流动人口婚育证明》程序").Append("\n");
            //sb.Append("咨询电话：0750—8930813  0750—8930829");
            sb.Append("感谢您对鹤山市沙坪街道人口和计划生育服务中心的关注，我们将为您提供详尽的计生服务");
            return sb.ToString();
        }

        public string GetBirthList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("发送数字查询相关办事程序：").Append("\n");
            sb.Append("11.办理一胎生育审核登记程序").Append("\n");
            sb.Append("12.办理再生育审批登记程序").Append("\n");
            sb.Append("13. 领取或补领《计划生育服务证》");
            return sb.ToString();
        }

        public string GetMarriageList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("发送数字查询相关办事程序：").Append("\n");
            sb.Append("21.沙坪户籍未婚者办理《流动人口婚育证明》").Append("\n");
            sb.Append("22.沙坪户籍已婚者办理《流动人口婚育证明》").Append("\n");
            sb.Append("23.外来流动人口办理《流动人口婚育证明》");
            return sb.ToString();
        }

        public string GetPlanningList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("发送数字查询相关办事程序：").Append("\n");
            sb.Append("31.沙坪户籍人口").Append("\n");
            sb.Append("32.广东省内流动人口").Append("\n");
            sb.Append("33.广东省外流动人口").Append("\n");
            sb.Append("34. 《独生子女父母光荣证》");
            return sb.ToString();
        }

        public string GetAidsList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("发送数字查询相关办事程序：").Append("\n");
            sb.Append("41.农村计划生育家庭奖励金申领").Append("\n");
            sb.Append("42.农村计划生育节育奖励金申领").Append("\n");
            sb.Append("43.城镇独生子女父母计划生育奖励金申领").Append("\n");
            sb.Append("44.计划生育家庭特别扶助金申领");
            return sb.ToString();
        }

        public string getOtherPlanningMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("一、新婚班：每个月8号下午2:30分，鹤山市计划生育服务站四楼（地址：沙坪街道新华路41号，财贸幼儿园对面），携带双方户口薄、结婚证、笔，新婚班设有免费孕前检查，可自愿参加；").Append("\n");
            sb.Append("二、免费B超检查：育龄妇女可到计生部门（包括鹤山市计生服务站、沙坪街道计生服务中心和流动人口综合服务中心（镇南工业城）进行免费的B超检查，时间为星期一至五：上午8:30-12:00，下午： 2:30-5:30；").Append("\n");
            sb.Append("三、免费药具发放：育龄夫妇可到沙坪街道计生服务中心或村居免费领取避孕药具").Append("\n");
            return sb.ToString();
        }

        public string getOneTwoList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("发送数字查询相关办事程序：").Append("\n");
            sb.Append("51.实施时间及独生子女的界定").Append("\n");
            sb.Append("52.“单独两孩”的衔接").Append("\n");
            sb.Append("53.单独再婚夫妇的生育政策").Append("\n");
            sb.Append("54.申请和审批流程");
            return sb.ToString();
        }

        public string getCooperativeList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("发送数字查询相关办事程序：").Append("\n");
            sb.Append("61.申请对象条件").Append("\n");
            sb.Append("62.申请资料").Append("\n");
            sb.Append("63.办理程序");
            return sb.ToString();
        }

        public string getRewardList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("发送数字查询相关办事程序：").Append("\n");
            sb.Append("71.农村计划生育家庭奖励").Append("\n");
            sb.Append("72.农村计划生育节育奖励").Append("\n");
            sb.Append("73.独生子女计划生育奖励").Append("\n");
            sb.Append("74.计划生育家庭特别扶助金");
            return sb.ToString();
        }

        public string getPhoneServiceMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("电话咨询服务：计生服务咨询电话：0750-893013 0750-8930829").Append("\n");
            sb.Append("扶助、奖励咨询电话：0750-8930831").Append("\n");
            sb.Append("地址：鹤山市沙坪街道新环路833号一楼办证大厅（松鹤新城后面）。");
            return sb.ToString();
        }

        public string GetOneBabyMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("办理一胎生育审核登记程序：").Append("\n");
            sb.Append("1、先参加新婚夫妇学习班，领取学习资料和申请生育登记表，待怀孕三个月后带备女方身份证、夫妻双方户口簿、结婚证、《计划生育服务证》、女方小一寸照片一张及孕检簿、若属再婚的还须带备离婚证和离婚协议书或法院的离婚判决书到沙坪街道卫生和人口计划生育局审核登记，签订计划生育合同；").Append("\n");
            sb.Append("2、如果女方为鹤山市籍外人口，男方为本地户籍人口，但女方在男方本地长期居住的，须提供女方户籍地乡镇（街）计生办出具的婚育状况证明，并同意在男方申请一孩生育登记手续方可办理。").Append("\n");
            sb.Append("3、如果女方为鹤山市籍非沙坪户口，须回女方户籍地计生部门申办。");
            return sb.ToString();
        }

        public string GetReBirthMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("办理再生育审批登记程序：").Append("\n");
            sb.Append("1、带备双方身份证、全家户口簿、双方结婚证、《计划生育服务证》、女方当月到计生部门进行B超检查的证明、现有孩子的出生医学证明、女方小一寸照片一张，若属再婚申请再生育的还须带备离婚证和离婚协议书或法院的离婚判决书；").Append("\n");
            sb.Append("2、先向女方户籍村、居委会提出申请，填写一式四份《再生育一个子女申请表》并加具意见和公章；").Append("\n");
            sb.Append("3、再到沙坪街道卫生和人口计划生育局审核，条件符合的办理审批登记手续，签订计划生育合同；").Append("\n");
            sb.Append("注：第一胎子女为残疾儿的，应有地级以上市病残儿医学鉴定组织的鉴定结论材料；再婚的，应附有法院民事调解书或判决书或离婚协议书或丧偶的死亡证明书；患不孕症的，应有县级以上医疗、保健机构出具的鉴定书。");
            return sb.ToString();
        }

        public string GetPlanBirthMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("领取或补办《计划生育服务证》程序：").Append("\n"); ;
            sb.Append("带备双方身份证、全家户口簿、双方结婚证、现有小孩出生医学证明、女方小一寸照片一张。").Append("\n");
            sb.Append("1、已生育一孩的，须带备上环证和当月到计生部门进行B超检查的证明；").Append("\n");
            sb.Append("2、已生育二孩或以上的，须带备结扎证，若不能结扎的须有医学上鉴定“不适宜结扎”的医学证明，若违反政策生育的要带备社会抚养费收款收据；").Append("\n");
            sb.Append("3、若属再婚的还须带备离婚证和离婚协议书或法院的离婚判决书；").Append("\n");
            sb.Append("4、先到所在村、居委会出具证明后，再到沙坪街道卫生和人口计划生育局办理。");
            return sb.ToString();
        }

        

        public string GetFlowWebBirthMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("沙坪户籍未婚者办理《流动人口婚育证明》程序：").Append("\n"); ;
            sb.Append("带备身份证、户口簿、小一寸照片一张。到所在村（居）委会申请，填写申请表，一式两份，并加具意见和公章，再到沙坪街道卫生和人口计划生育局申领《流动人口婚育证明》。（凡流出鹤山市外的人员须办理此证件）");
            return sb.ToString();
        }

        public string GetMarriedWebBirthMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("沙坪户籍已婚者办理《流动人口婚育证明》程序：").Append("\n"); ;
            sb.Append("带备双方身份证、全家户口簿、双方结婚证、《计划生育服务证》、现有小孩出生医学证明、社会抚养费收款收据、小一寸照片一张。").Append("\n");
            sb.Append("1、已生育一孩的，须带备当月到计生部门进行B超检查的证明；").Append("\n");
            sb.Append("2、已生育二孩或以上的，须带备结扎证，若不能结扎的须有医学上鉴定“不适宜结扎”的医学证明，若违反政策生育的要带备社会抚养费收款收据；").Append("\n");
            sb.Append("3、若属再婚的还须带备离婚证和离婚协议书或法院的离婚判决书；").Append("\n");
            sb.Append("4、先到所在村（居）委会申请，填写申请表，一式两份，并加具意见和公章；再到沙坪街道卫生和人口计划生育局申领《流动人口婚育证明》。（凡流出省外的人员须办理此证件）");
            return sb.ToString();
        }

        public string GetFloatingPopulationWebBirthMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("外来流动人口办理《流动人口婚育证明》程序：").Append("\n");
            sb.Append("1、办理对象为已采取结扎措施并在本地务工和居住一年以上的省外已婚育龄妇女。").Append("\n");
            sb.Append("2、须带备双方身份证、全家户口簿、双方结婚证、结扎证，如违反计划生育的还要带备社会抚养费收款收据（若未缴交完毕，请出示《分期缴纳社会抚养费保证书》或户籍地乡镇（街）计生部门出具的社会抚养费征收情况证明），若属再婚的还须带备离婚证和离婚协议书或法院的离婚判决书到沙坪街道卫生和人口计划生育局办理。").Append("\n");
            sb.Append("3、先到居住地所在村、居委会出具证明后，再到沙坪街道卫生和计划生育局办理。");
            return sb.ToString();
        }

        public string GetEveryPlanProveMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("沙坪户籍人口办理计生证明：").Append("\n"); ;
            sb.Append("带备双方身份证、全家户口簿、双方结婚证、《计划生育服务证》、社会抚养费收款收据、现有小孩出生医学证明、小一寸照片一张。").Append("\n");
            sb.Append("1、已生育一孩的，须带备当月到计生部门进行B超检查的证明；").Append("\n");
            sb.Append("2、已生育二孩或以上的，须带备结扎证，若不能结扎的须有医学上鉴定“不适宜结扎”的医学证明，若违反政策生育的要带备社会抚养费收款收据；").Append("\n");
            sb.Append("3、若属再婚的还须带备离婚证和离婚协议书或法院的离婚判决书；").Append("\n");
            sb.Append("4、先到所在村、居委会出具证明后，再到沙坪街道卫生和人口计划生育局办理。");
            return sb.ToString();
        }

        public string GetInProvinceFloatingPopulationPalnMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("省内流动人口办理计生证明:").Append("\n");
            sb.Append("带备双方身份证、全家户口簿、双方结婚证、《计划生育服务证》、现有小孩出生医学证明、社会抚养费收款收据、小一寸照片一张。").Append("\n");
            sb.Append("1、已生育一孩的，须带备当月到计生部门进行B超检查的证明；").Append("\n");
            sb.Append("2、已生育二孩或以上的，须带备结扎证，若不能结扎的须有医学上鉴定“不适宜结扎”的医学证明，若违反政策生育的要带备社会抚养费收款收据；").Append("\n"); ;
            sb.Append("3、若属再婚的还须带备离婚证和离婚协议书或法院的离婚判决书；（若未缴交完毕，请出示《分期缴纳社会抚养费保证书》或户籍地乡镇（街）计生部门出具的社会抚养费征收情况证明）；").Append("\n");
            sb.Append("4、先到所在村、居委会出具证明后，再到沙坪街道卫生和人口计划生育局办理。").Append("\n");
            sb.Append("注：凡以上属鹤山市内非沙坪户籍的人员，请先到户籍地镇卫生和人口计划生育局出具计划生育证明。");
            return sb.ToString() ;
        }

        public string GetFloatingPopulationPalnMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("省外流动人口办理计生证明:").Append("\n");
            sb.Append("带备双方身份证、全家户口簿、双方结婚证、《流动人口婚育证明》、现有小孩出生医学证明、社会抚养费收款收据、小一寸照片一张。").Append("\n");
            sb.Append("1、已生育一孩的，须带备当月到计生部门进行B超检查的证明；").Append("\n");
            sb.Append("2、已生育二孩或以上的，须带备结扎证，若不能结扎的须有医学上鉴定“不适宜结扎”的医学证明，若违反政策生育的要带备社会抚养费收款收据；").Append("\n");
            sb.Append("3、若属再婚的还须带备离婚证和离婚协议书或法院的离婚判决书；（若未缴交完毕，请出示《分期缴纳社会抚养费保证书》或户籍地乡镇（街）计生部门出具的社会抚养费征收情况证明）；").Append("\n");
            sb.Append("4、先到所在村、居委会出具证明后，再到沙坪街道卫生和人口计划生育局办理。").Append("\n");
            sb.Append("注：凡省内外户籍迁入的人员除带备以上资料外，还须持户籍地乡镇计生部门出具的计划生育状况证明。");
            return sb.ToString();
        }

        public string GetOneChildParentsMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("办理《独生子女父母光荣证》程序：").Append("\n"); ;
            sb.Append("1、带备夫妻双方身份证、全家户口簿、双方结婚证、《计划生育服务证》、上环证和当月到计生部门进行B超检查的证明、现有小孩出生医学证明、父母与独生子女大一寸合照四张，到沙坪街道卫生和人口计划生育局领取申请表；").Append("\n");
            sb.Append("2、领取申请表后到所在单位、村（居）委会审核，加具意见和公章，再到沙坪街道卫生和人口计划生育局办理。");
            return sb.ToString();
        }

        public string GetCountryFamilyBonusMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("农村计划生育家庭奖励金申领程序：").Append("\n");
            sb.Append("1、符合奖励条件人员持双方身份证、全家户口簿、小孩出生证、准生证、结婚证、独生子女证或结扎证及有关证明材料向户籍地村委会领取并填写《广东省农村计划生育奖励金申请表》；").Append("\n");
            sb.Append("2、经村委会初审和公布、镇（街）卫生和人口计划生育局审核、市人口计生局确认后，由镇（街）卫生和人口计划生育局发放《广东省计划生育奖励金发放证》；").Append("\n");
            sb.Append("3、计划生育奖励对象凭本人身份证、户口簿、《发放证》和银行存折到当地的代发单位按月领取奖励金。");
            return sb.ToString();
        }

        public string GetCountryPlanBonusMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("农村计划生育节育奖励金申领程序：").Append("\n");
            sb.Append("1、凡符合奖励条件沙坪街道的农村居民双方身份证、全家户口簿、小孩出生证、准生证、结婚证、结扎证、计划生育服务证及有关证明材料，向户籍地村委会领取并填写《江门市农村计划生育节育奖励金申请表》；").Append("\n");
            sb.Append("2、经村委会初审和公布、镇（街）卫生和人口计划生育局审核、市人口计生局确认后，由镇（街）卫生和人口计划生育局发放《江门市计划生育奖励金发放证》；").Append("\n");
            sb.Append("3、计划生育节育奖励对象凭本人身份证、户口簿、《发放证》和银行存折到当地的代发单位按月领取奖励金。");
            return sb.ToString();
        }

        public string GetCityParentPlanBonusMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("城镇独生子女父母计划生育奖励金申领程序：").Append("\n");
            sb.Append("凡符合奖励条件的沙坪街道城镇户籍独生子女父母，均可持居民身份证、全家户口簿、结婚证、小孩出生证、独生子女父母光荣证或单位证明、退休证（单位退休须提供）、收养证或收养公证书（属收养须提供）等材料的原件和复印件，");
            sb.Append("免冠（1寸）近照3张，向户籍所在地的村（居）民委员会申请，领取并填写一式三份《广东省城镇独生子女父母计划生育奖励申请表》，交由村（居）民委员会代办。");
            sb.Append("夫妻双方的户籍不在同一个镇（街）的，向女方户籍所在地申请；夫妻双方户籍不在同一个市的，分别向各自户籍所在地提出申请。");
            return sb.ToString();
        }

        public string GetPlanFamilySpecialBonusMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("计划生育家庭特别扶助金申领程序：").Append("\n");
            sb.Append("凡符合规定扶助条件的沙坪街道户籍独生子女父母，均可持居民双方身份证、全家户口簿、小孩出生证、准生证、结婚证、独生子女父母光荣证、收养证或收养公证书、独生子女的残疾人证或死亡证等材料的原件和复印件，免冠（1寸）近照3张，向户籍所在地的村（居）民委员会申请，领取并填写一式三份的《广东省计划生育家庭特别扶助金申请表》，交由村（居）民委员会代办。").Append("\n");
            sb.Append("夫妻双方的户籍在同一个县（市、区）但不在同一个镇（乡、街道）的，向女方户籍所在地申请；夫妻双方户籍不在同一个县（市、区）的，分别向各自户籍所在地提出申请。").Append("\n");
            sb.Append("离婚或丧偶的对象，由其本人申请，须同时提供离婚证或配偶的死亡证明材料。");
            return sb.ToString();
        }

        public string getDefinitionOnlyChildMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("实施时间及独生子女的界定：").Append("\n");
            sb.Append("我省从2014年3月27日起实施“单独两孩”政策，夫妻双方或一方为独生子女且只有一个子女的，由夫妻双方共同申请，经乡镇（街道）卫生和人口计划生育工作机构审批，可再生育一胎子女。独生子女的界定：独生子女是指夫妻生育或者合法收养的唯一子女，即没有同父同母、同父异母、同母异父的兄弟姐妹，或者曾有兄弟姐妹但兄弟姐妹均于生育子女前死亡。").Append("\n");
            sb.Append("以下情形可视为独生子女：").Append("\n");
            sb.Append("（一）由社会福利机构抚养成人且没有兄弟姐妹的。").Append("\n");
            sb.Append("（二）夫妇只生育一个子女，该子女以及该夫妇依法收养的查找不到生父母和兄弟姐妹的弃婴或儿童。").Append("\n");
            sb.Append("（三）只生育一个子女的夫妇离异后，该子女经法院判决或协议由一方抚养并长期共同生活，且抚养方未再婚或再婚后未再生育的。");
            return sb.ToString();
        }

        public string getOnlyTowChildJoinMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("“单独两孩”的衔接：").Append("\n");
            sb.Append("（一）对在我省“单独两孩”政策实施前已经生育的“单独”夫妇，依照生育行为发生时《广东省人口与计划生育条例》的规定处理。").Append("\n");
            sb.Append("（二）对于户籍从外省迁入我省并在我省提出按“单独”申请再生育的，应以我省规定的标准予以确认。").Append("\n");
            sb.Append("（三）已办理独生子女父母光荣证的“单独”夫妇，可申请再生育一胎。批准再生育时应收回独生子女父母光荣证，并停止发放独生子女保健费。").Append("\n");
            sb.Append("（四）按《广东省农村计划生育节育奖励办法》规定领取奖励的“单独”夫妇，如符合再生育条件，可申请实施输卵（精）管复通手术。自批准再生育当月起，停止发放奖励金。");
            return sb.ToString();
        }

        public string getMarriedAgainBirthMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("单独再婚夫妇的生育政策：").Append("\n");
            sb.Append("对单独再婚夫妇有以下情形的，可允许再生育一胎子女").Append("\n");
            sb.Append("（一）独生子女一方未生育子女，另一方已生育一个子女，双方婚后生育一个子女且家庭只有该子女的。").Append("\n");
            sb.Append("（二）独生子女一方未生育子女，另一方已生育两个子女的。").Append("\n");
            sb.Append("（三）双方在婚前各生育一个子女的。");
            return sb.ToString();
        }

        public string getMarriedAgainBirthApprovalMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("“单独两孩”再生育的申请和审批流程：").Append("\n");
            sb.Append("（一）“单独”夫妇双方携带身份证、户口簿、结婚证、计划生育服务证的原件和复印件，到户籍所在乡镇（街道）卫生和人口计划生育工作机构领取并填写《“单独”夫妇再生育申请审批表》，即可办理“单独两孩”再生育审批全部手续。").Append("\n");
            sb.Append("（二）“单独”夫妇双方为我省同一乡镇（街道）的，由夫妇双方直接向户籍所在乡镇（街道）卫生和人口计划生育工作机构提出申请。").Append("\n");
            sb.Append("（三）“单独”夫妇双方为省内同一地级以上市户籍但不在同一个乡镇（街道）的，由夫妇双方向女方户籍所在乡镇（街道）卫生和人口计划生育工作机构提出申请。").Append("\n");
            sb.Append("（四）“单独”夫妇户籍不在省内同一个地级以上市，但女方常住在男方户籍地的，可由夫妇双方向男方户籍所在乡镇（街道）卫生和人口计划生育工作机构提出申请。").Append("\n");
            sb.Append("（五）“单独”夫妇一方为我省户籍，另一方为外省户籍的，可自愿选择由夫妇双方向我省一方户籍所在乡镇（街道）卫生和人口计划生育工作机构提出申请。").Append("\n");
            return sb.ToString();
        }

        public string getRuralCooperativeApplicationMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("农村合作医疗申请对象条件:").Append("\n");
            sb.Append("（一）1973年6月30日以后出生的户籍属我市农村户口的独生子女户（含合法收养）和纯生二女结扎户的未婚子女（已婚的只是其父母享受）及其父母").Append("\n");
            sb.Append("（二）1992年4月1日以后收养的，要有民政部门颁发的收养证").Append("\n");
            sb.Append("（三）独生子女户要持有《独生子女父母光荣证》，如符合条件未办理的可到镇（街）人口计生办办理（14周岁以下的补办独生子女父母光荣证，14周岁以上的由计生部门出具独生子女证明）").Append("\n");
            sb.Append("（四）纯二女户必须是夫妇一方落实了结扎措施的，凭结扎证明经计生办核定。").Append("\n");
            sb.Append("（五）其他不符合申请的条件：").Append("\n");
            sb.Append("  ①结婚后没有生育或者非法收养的").Append("\n");
            sb.Append("  ②1973年6月30日以前出生独生子女户、纯二女户").Append("\n");
            sb.Append("  ③1983年6月30日以前夫妻中女方已经退出育龄期（49周岁）的").Append("\n");
            sb.Append("  ④1973年6月30日以前已经丧偶、离婚而在1973年6月30日以后未再婚的");
            return sb.ToString();
        }

        public string getRuralCooperativeAppliedDataMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("农村合作医疗申请资料：").Append("\n");
            sb.Append("复印全家户口本（含首页）、准生证复印件、独生户的复印独生子女证、纯二女户的复印结扎证、离婚的对象复印离婚协议书");
            return sb.ToString();
        }

        public string getRuralCooperativeGoThroughMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("农村合作医疗办理程序：").Append("\n");
            sb.Append("请带齐上述资料到户籍所在地的村委会办理");
            return sb.ToString();
        }



        public string getRuralFamilyPlanningRewardMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("农村计划生育家庭奖励").Append("\n");
            sb.Append("1.奖励对象：本市农村户口中男性年满60周岁、女性年满55周岁的下列人员：").Append("\n");
            sb.Append("（一）只生育（含收养、抱养，下同）一个子女的农村居民").Append("\n");
            sb.Append("（二）纯生儿女的农村居民").Append("\n");
            sb.Append("（三）婚后没有生育的农村居民").Append("\n");
            sb.Append("奖励对象，包括丧偶、离婚以及再婚家庭中没有与继子女形成抚养关系的独生子女、无子女方配偶等。").Append("\n");
            sb.Append("2.奖励标准：按每人每月80元的标准发放，直至本人死亡为止。");
            return sb.ToString();
        }

        public string getRuralPlanningBirthControlRewardMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("农村计划生育节育奖励").Append("\n");
            sb.Append("1.奖励对象：本市农村户籍居民，符合生育政策，只生育（含依法收养）一个子女或纯生二女或婚后未生育，且一方落实绝育措施的已婚夫妇，自落实绝育措施当月起至男满60周岁，女满55周岁止。").Append("\n");
            sb.Append("2.奖励标准：自发放之月起，奖励金按每人每月50月的标准发放。").Append("\n");
            sb.Append("3.以下对象不再列入奖励范围：").Append("\n");
            sb.Append("（一）已办理养老保险的对象").Append("\n");
            sb.Append("（二）已办理养老储蓄的对象").Append("\n");
            sb.Append("（三）已领取一次性奖励（夫妻双方共1000元）的对象").Append("\n");
            sb.Append("（四）未办理结婚登记生育第一个子女，六十日内未补办结婚登记的对象").Append("\n");
            sb.Append("（五）未经审批再生育的对象").Append("\n");
            sb.Append("（六）未依法办理收养登记子女的对象").Append("\n");
            sb.Append("（七）凡已享受过其他形式的农村计划生育节育奖励的对象");
            return sb.ToString();
        }

        public string getTownFamilyPlanningRewardMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("城镇独生子女父母计划生育奖励").Append("\n");
            sb.Append("1.奖励对象：").Append("\n");
            sb.Append("（一）本镇户籍城镇居民中，1980年2月2日至2008年12月31日期间，男性年满60周岁、女性年满55周岁（以下简称规定年龄）的无单位人员（包括个体工商户及其从业人员、无业、下岗失业人员等），且同时符合以下条件的：").Append("\n");
            sb.Append("①只生育（含依法收养）一个子女或终身没有生育（含依法收养）子女的；").Append("\n");
            sb.Append("②未享受过独生子女父母计划生育奖励或补助的。独生子女死亡的，不适用本办法。").Append("\n");
            sb.Append("（二）自2009年1月1日起，本镇户籍城镇居民中（包括省内、省外迁入本镇），达到规定年龄且未享受《广东省人口与计划生育条例》（以前称《广东省计划生育条例》）规定的计划生育奖励的独生子女父母。独生子女死亡的，不适用本办法。").Append("\n");
            sb.Append("2.独生子女的界定： 独生子女是指夫妻生育或者合法收养的唯一子女，即没有同父同母、同父异母、同母异父的兄弟姐妹，或者曾有兄弟姐妹但兄弟姐妹均于生育子女前死亡。").Append("\n");
            sb.Append("3.奖励标准：2009年之前的按照当年标准一次性奖励；2009年1月1日起达到规定年龄的独生子女父母按每人每月80元的标准发放。");
            return sb.ToString();
        }


        public string getFamilyPlanningSpecialAssistanceMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("计划生育家庭特别扶助金").Append("\n");
            sb.Append("1.扶助对象：本镇户籍人口独生子女死亡或伤、病残后未再生育或者收养子女的夫妻。扶助对象应同时符合以下条件：").Append("\n");
            sb.Append("（一）1933年1月1日以后出生").Append("\n");
            sb.Append("（二）女方年满49周岁").Append("\n");
            sb.Append("（三）只生育一个子女或和合法收养一个子女").Append("\n");
            sb.Append("（四）现无存活子女或独生子女被依法鉴定为残疾（伤病残达到三级以上）").Append("\n");
            sb.Append("（五）因丧偶或离婚的单亲家庭，男方或女方需年满49周岁");
            return sb.ToString();
        }

        public string getOnlineMsg()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("感谢您对鹤山市沙坪街道人口和计划生育服务中心的关注,我们的在线咨询时间为周一至周五早上9点-11点，下午2点-5点（法定节假日除外）");
            return sb.ToString();
        }

    }
}
