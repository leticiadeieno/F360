﻿using System;
using Klingon.Domain.Core.Contracts;
using SimpleInjector;
using Klingon.Domain.Core.IoC;

namespace Klingon
{
    class Program
    {
        static void Main()
        {
            try
            {
                Container container = new Container();
                Resolver.Register(container);
                IKlingonService _klingonService = container.GetInstance<IKlingonService>();

                string optionChoise = string.Empty;
                string textB = "lqvxj prbf dgxv cgc wqvxbjs dbs msvtlbr frsm wbdqdg xhpjp jzfcchbs qjq zqtcjlkm slt tzbc nsr wjhzxd rffqbkm dvfn gsvfgb blxxngsh zchhpqg dxmk zwngclz cgv tgxznzlg pvdnnx rnbj vwx xhrzg zdq bjqdhkps dmpb gkk vfr whmxrbm pngfqc nlbd xgm cbpqw vvgxpv vzbbgx jlmtdcdk xvrmvkmt zbkvzjx bslb dtzwvk jsvk qqr llp mxhjqck gkhmf xvqfqcjj ffvx zvmqpsm sxx vtbhc nhfg gcprb nxlctr dsbnb kwggfpw tqm fnvpsl vxdpzb ljcfrxg rzq mfq hgrwcx pbktg nkslbdgc rslj xkrx hmdrsk nhf wwrqwtz lfqqjzw qdcvzvjc kdmmh wqnnkmcm qkwmdxlf mctc xkv nrbx lbdj tdxgbb hpv gzvgndnb lhsvjxdd nvf mvlpsghr skvtfpw fjjxcp dvf dnjdzcrc bkv qsqplh rxcw tfnwhw lbttltk kphjcw sgmx tdgjvqdb pmvhqzf rzhb fkxmsdw svqcpq hhx pprkm shh lfrstvcd rdkdqqq ddhgdcr tsk fmktwj trv ltwnhthz nml tsl kpzgksnh ndz qtqglj dbwmdvh wgrvdklq csnlxvnj dcnzgs wwzr ngtc vppg fbvsdr vmx rkzcgw jjglmvb rpd rvdgxtnr xqgshj vclcmnh smbhg xmjlklzl mcbz slkbsj xbnpc fzhjvm nmlwfjzp jpdbf qtgcdr vqb pbn pckrfls nbrntt vjvr xfznh rncvwwqq mhdmtcc ffvnk slw grzxqblp ngfw gbmvvzvq qhrh trjbrzp cbzl rgspsq ljjtc rwfnm vkmzlgzc kcmjjd shv xxzv xnmgwfv lmrwzpw qpzlp jzjj pmwqhz pbrfsrg nswcjr wmvczg tljp mwrggrf vss fmblgjv mpfzbnfc prjnll xvhqt gbzg tfhjnc mrpd zdm rhj gvx flwhzqjc dkmk mpr vbf kqfl bhnw gfksm njmgtlm wqhvvfdl xhpxdp zdcrscjs gvqbj xjcf dqdmfcx dwcbkxw nslnvnb wjfmtngs fcrzzgw qhbr gmkkcx pzsqlz csj pwsccx xhpsmr tsglsbh dfmqqscc jwnmzzdc xljfh hllng llswvqf xvjczjqh rwhznhqc mwhj jkz kxg blpwlzv vxzlwz tzdtfs jpdn gqbwkh mqhjxv fxjllq zwnwtx flgp kdhvrrd mqd sslf xnwvvw thjplqgc xtlpxgg wwrpxqf rjtcchpx bjctn sds jdb pwtdlzs tqx jrmn nwjhl slbwz vmrqk kdfkwp dwhbsphh tkwt nmqsm ppb slcmvfvp vtvf djw mjndf cpmn wmfpxmkz hnzmsr fjkvvx thn hnvdt wtgpkv rgs qcdtjqqd jccdspqd rbkhmz hshmrpg xkjnccwt qrt fkfs bfdwt xsdnh bfdhjthj csk wksvnnf pbnj mczhlf gpnqtfbd zwwpz zvn rthljf ltw stgsds gcjkqn rdgtf pmcwsnnr bdwmdh rgtcs lqdrhbpt zmprxdms nxzmdx slpgfx cpltlszl zwrfsp pqrphcgm htwpkmn kwpntvvg nrfkdfx ksxz zfvx qzgppkd lfr mqwz tvcvgpqh rrbjf fnrvbnm qmsv zkhvcdmg kkfbpng smhqq qtpqlkft slgbx wkvxwcm kgn mttrtqqs tjdtt rjrfsgzl xknsclbk mcbvdcnx rtgld wbbddlc gqmnpzzp gsxdnwqt prmkx ngj mpbxq zlzwhd wgsnv rcp jsk ckblv tfmsnv djlqn btrj cvxgjqh kvw shk hrfcp ktthmtw zdt nlggcz gwxlzgfw xtkvx rhcxr dlnn zbbjqqh rjnvgs psvsmt wskt bfsvwk txj brskv fbwcgm kbbpbf rmnpt tnvrmdk wnslrsfw lfbcg pxt mnwk dcpvcwq xbpgzfhn gpjp lsfbr sdgdxhq pjltpnvh vtjps btqgwnx bkpjtxxm zgjfr cbttjszl zlgwfhsw klf zpgrx zbfxbrzr msm hrhfgfd bpmx xmnrh ncnhxnwk gtzn fdsbb xbrtsjv ltsxscx bvbmnnwp gblnr ljcv sqnkt skrh svb jchd bqvsd ljx jgjdb fxlkmcvj tvglz qkjkdld bqk bsl vdhknm djjdb hppprkz bdfccz dqqp wsmw cvvn dbnqxf dxzvtsc zqwqds nqdtvvpl mqcs bmsmq smthjb pplbtrw lpmddf hrsjfdzp hbpbb mgpnspj rwz pvgq psf cdvrl jmwkrt ljhnsql mddwc mcvhvk rnfx xqxfblzh nxf dwhxs pgdt mtcfxhth jtnwbwb zkfnzflb fsvkvpn vsgwhvp xln mbhx vxn bwdwsmr pszmbbkc cxdhlsns fltrkh gmfdrhws pnpczv lxzdlg hmllsbm cddnd jntxtzr qztdgfz npdgdlsf lkmg swsxjms njs vrddwhkh wwzp lcczhhm kdz jjl phbwrbm kkwww zrqqzq tpqb bsdtmhb dtpdfhp mnmp gcv mtvlh cgdrcr gqvdj mxvsn hdmhn wqfr dljnvlzw phtzsmg hqdjc ttm jtpx vkwq zcs nfq fcjkqqc ntqfwvws klckb cmwv tbrh zktqsjf vmxkz ttngcchg pmjnsvjf mhksp qhh gpjr ftnrfrkl xdbxxj wdlfbx phzwfrxr pldbsmh wlljvz gznxd lvw nhpf jxv fhnhs nqczswv gpkxpzqs dztx ncfqfp xkj qpgshfv jsddbs pzfm bzfqmbx dmbkskh dllmlw zsh nzpdw kxslnqn pjlcmcxf jvcgmflg vcc cxbcwz jlkhsvmx dvxndqf kcbllpw zqb rzfw fbwvmcd qns fmqx wqrtmw rzpss bcxg rdjkwd tfkfnj bnqqj cjzpz hxbvlst rtlpt vrcwh qsh nkcrwhq stssffng hbt qrppcch vdkbrgc btr mmjwp fmstk rvjv gjnljlvv vbwxppd rcpql khnvl vmlpxtwb csd rtjh kjllq xsnfw tmrc xfglnt spdxfn kmvxx qtf kpmkjl fxxrchdg tzwl jqwd qjx zmqqbd jmvk vjldrv pqspncnk scmz zjzt dplp hhpt rwldkr mcbnbr kpx hxdz msdvx dbxcr hldpxf djxflkz hdhkfqh vsvzzft xwwxj pbqm ltfcl qnqd gslsk sdkzg ttxcwpc fkmlmqtk";
                var listTextB = textB.Split(' ');

                do
                {
                    Console.WriteLine("Digite o número de acordo com o item desejado: \n1-Preposições\n2-Verbos\n3-Verbos em Primeira Pessoa\n4-Sair");
                    optionChoise = Console.ReadLine();

                    switch (optionChoise)
                    {
                        case "1":
                            var countPrepositions = _klingonService.CountPrepositions(listTextB);
                            Console.WriteLine(string.Format("A quantidade de Preposições é: {0} \n", countPrepositions));
                            break;
                        case "2":
                            var countVerbs = _klingonService.CountVerbs(listTextB);
                            Console.WriteLine(string.Format("A quantidade de Verbos é: {0} \n", countVerbs));
                            break;
                        case "3":
                            var countVerbsInFirstPerson = _klingonService.CountVerbsInFirstPerson(listTextB);
                            Console.WriteLine(string.Format("A quantidade de Verbos em Primeira Pessoa é: {0} \n", countVerbsInFirstPerson));
                            break;
                        default:
                            Console.WriteLine("Opção Inválida!\n");
                            break;
                    }
                } while (optionChoise != "4");           
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Ocorreu um erro ao rodar a aplicação: {0}", ex.Message));
            }
        }
    }
}
