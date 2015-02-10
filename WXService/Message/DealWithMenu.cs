using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.Menu;
using WXService.Common;

namespace WXService.Message
{
    public class DealWithMenu
    {
        public static MenuJson GetMenuJson()
        {
            MenuInfo BeneficialInfo = new MenuInfo("惠民服务", new MenuInfo[] {
                new MenuInfo("办理生育服务证",ButtonType.CLICK,"birth"),
                new MenuInfo("流动人口婚育证明",ButtonType.CLICK,"marriage"),
                new MenuInfo("办理各类计生证明",ButtonType.CLICK,"planning"),
                new MenuInfo("奖励/扶助",ButtonType.CLICK,"aids"),
                new MenuInfo("其他计生服务",ButtonType.VIEW,"http://spjs.chinacloudsites.cn/static/OtherPlanning.html")
            });

            MenuInfo PolicyInfo = new MenuInfo("政策宣传", new MenuInfo[] { 
                new MenuInfo("单独两孩政策",ButtonType.CLICK,"oneTwo"),
                new MenuInfo("农村合作医疗",ButtonType.CLICK,"cooperative"),
                new MenuInfo("奖励/扶助",ButtonType.CLICK,"reward"),
                new MenuInfo("政策法规",ButtonType.CLICK,"law")
            });

            MenuInfo NotificationInfo = new MenuInfo("关注我们", new MenuInfo[]{
                new MenuInfo("通知通告",ButtonType.CLICK,"activity"),
                new MenuInfo("电话咨询服务",ButtonType.CLICK,"phone"),
                new MenuInfo("在线咨询服务",ButtonType.CLICK,"online"),
                new MenuInfo("特色工作",ButtonType.CLICK,"characteristic"),
                new MenuInfo("保健卫生知识",ButtonType.CLICK,"health")
            });

            MenuJson MJ = new MenuJson();
            MJ.button.AddRange(new MenuInfo[] { BeneficialInfo, PolicyInfo, NotificationInfo });

            return MJ;

        }
    }
}
