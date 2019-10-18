﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace Day4
{
    internal class Program
    {
        private static void Main()
        {
            const string FULL_LIST = "kvvfl kvvfl olud wjqsqa olud frc\r\nslhm rdfm yxb rsobyt rdfm\r\npib wzfr xyoakcu zoapeze rtdxt rikc jyeps wdyo hawr xyoakcu hawr\r\nismtq qwoi kzt ktgzoc gnxblp dzfayil ftfx asscba ionxi dzfayil qwoi\r\ndzuhys kfekxe nvdhdtj hzusdy xzhehgc dhtvdnj oxwlvef\r\ngxg qahl aaipx tkmckn hcsuhy jsudcmy kcefhpn kiasaj tkmckn\r\nroan kqnztj edc zpjwb\r\nyzc roc qrygby rsvts nyijgwr xnpqz\r\njqgj hhgtw tmychia whkm vvxoq tfbzpe ska ldjmvmo\r\nnyeeg omn geyen ngyee rcjt rjuxh\r\nqpq udci tnp fdfk kffd eyzvmg ufppf wfuodj toamfn tkze jzsb\r\nrrcgxyp rbufd tfjmok vpyhej hcnz ftkojm\r\njnmomfc jnmomfc bkluz izn ovvm flsch bkluz\r\nodisl hzwv hiasrhi hez ihihsra qpbmi ltwjj iknkwxf nbdtq gbo\r\ngjtszl gjtszl fruo fruo\r\nrdapv gaik cqboix sxnizhh uxmpali jdd usqnz advrp dze\r\nflooz flooz qad tcrq yze bnoijff qpqu vup hyagwll\r\nlnazok dze foi tqwjsk hpx qcql euzpj mwfrk\r\nilb fmviby ivybmf gtx xtg\r\nrpauuu timere gyg wcolt ireetm safi\r\ncroe szwmq bbhd lciird vhcci pdax\r\nhnc ykswt qqqmei goe bri wmyai hnc qpgqc pberqf bzs\r\nhsnrb wdvh iezzrq iezzrq rdbmpta iezzrq kemnptg alkjnp wymmz\r\nngw don ddvyds nlhkoa aaf gptumum ugtpmmu\r\nvmccke qbpag kvf kvf tgrfghb kvf bhpd sglgx\r\nobomgk bkcgo yso ttft vbw ckl wjgk\r\nfli qvw zhin dfpgfjb udsin nihz ovr tiewo\r\ntgmzmph hauzieo jmg tdbtl lvfr qpaayq qapaqy ausioeu jun piygx\r\njkp guqrnx asdqmxf vmfvtqb tloqgyo ioix gajowri tmek ilc puhipb\r\nuycn zxqm znft ayal znacus kvcyd ekv qqfpnh\r\nfqghur xtbtdd ztjrylr bpuikb ziyk\r\nrvakn uqbl ozitpdh uqbl dsej xehj\r\nlaxp haz jyd xnkrb ijldth woy xapl iqgg alpx gnupa ukptmmh\r\ndyiy dyiy ihb qcyxr\r\nwbwkd hdwu zvgkn hdwu wjc sakwhn zxujdo npllzp uyr uyr\r\nfxczpmn cininu akcxs ggslxr riyxe ojisxe\r\nppbch sampq dnct afikor dnct edsqy pnzyzmc afikor\r\njnvygtn hijqjxl vsd jnvygtn nqcqv zns odq gkboxrv kolnq wrvd\r\nmroq mroq flsbu flsbu\r\nfyshor xvpaunj qmktlo xoce wkiyfu ukcl srndc ugwylwm ozcwdw mtqcste kpokr\r\ncfh cxjvx cfh cfh uewshh\r\nbpspbap bpspbap fquj mxmn bwls iirhvuk dmpkyt exrn mxmn\r\ntvyvzk ezszod ntxr xtnr och\r\nknfxhy kbnyl knfxhy xhkssx lxru uprh nkxpbx oodolxr tpvyf\r\nnblmysu iwoffs upgof tyagwf aan vovji ajk ywzq oyfi sfulz\r\naushzkm lcaeki mkuzsah ynxvte rsntd refk pcm\r\nmgguob gobmug dzenpty gmogbu\r\nyvq eepof rgnree nerger fpb stfrln ernger\r\nhrgkbl mzwvswk rsrsbk ieru holco pajvvn ztgsr qkyp fyeg owpcmoj\r\nfowda gmsqdca yugj mcrroxv mqcbojd fjnqfji qdfsc jqs\r\nqnc rvjfz vvxk sjd xrma ucdjvq sbw zydyt dfzww\r\nocajazv cozaajv tqunkla udwf ecnnmbz lsakqg bki njnda zsdu ccfqw rxpc\r\nqqm qdfya qxyx qmq qfday uqnfttt\r\nrnbirb iapor qet iapor hxkhz dfvzig pedl ybyb\r\nmkgamxg xkniv meb hbzmxjn dhbj zhbxjmn hdjb\r\nilteux pyutyfx mau lrr bacak\r\nsjjonmn dbbbgs crxyuu jztstgd ezb uiabyaa\r\ntra fle ufzlvf nnaw kec hiwnnlj tei wld iyt syk hjdczb\r\nqmd jtlud dgh dbanock fzp dsjgqru wwvo jwvxwgv xlemfij jcacd\r\nrpkx oxesil snazcgx fly miiyc ikmtmp oefyyn egbw\r\nypfpeu wldnyd acchppb yqwcaw wldnyd turbz megci nbgxq xkc ypfpeu\r\niqqv iqqv neui iqqv\r\nypsxm icqyup zyetrwq nbisrv\r\nviommi toszx dpueq eyy cunjou ffcjc jaeez djefra pxvkj liudlig yye\r\nfhnacbg jghchh ghjhhc iue hwqmo\r\nvbjw lpn cizba ltnsfpz tzoweml irewlc uzckhpd mszal obd\r\nyeos utxkft hflxkfe fxczge qpgigkc ksgr vuumql vhlvv\r\nxzmkv xzmkv krecdi klpem jsbu nwcmik emfzxf cjmpgnj\r\nvtkjo pmiv zou gxo qdiyxsf hwyinjk jhkgf rjq\r\ndyuoc ywiyvch irfgl ywiyvch fxb fxb\r\ntuz onhr syu rqya abkaf bcfx mbknex juwoor zmksl\r\noheg spjorx ksdy vwtq fxz phvtazk tcze lrxg\r\nhew lbup botaj ltr jpd\r\ndxgc tzinkej gnz hxvvub adsqmc dxgc asgpp rqbdcra goy pmamdua bhiacva\r\nxqv ygb kihxqz vyv pjcny vmyvsdv cgsi nfyx\r\ntqga ssshrw ndq qlbvwh huyd pxbgj qbxk dkkbf jxy chsobw pph\r\nhxl iwph iwph xnr otifm ljhre\r\nzlgvpd kapxpoc dve rklk ogh hgnp rbrmc zzkz hhmcx aklmo\r\nsar gfor nkf hek nkf aql shc aql\r\ndtcrw kfjzcjx qyhi bldson whwdayo mqtgt xhqzp ttqmg\r\nomspdml isze jdl nvwo qrkm wztfg ssfgyh dryj jhp unsmty\r\njxt cszylng ifht ixtuna azoi xutqlv jtx tjx\r\nusgm azuayp fgkby ezpyq jqwl ezofj\r\ntnhvil nrvg moyrpqs sldx qymoff megflxh pyhqwms xmdw\r\nzomy zcquwnv lzx bvcna yods mjp dgsez\r\nblklyf xokd gpit tiysj yrwfhm tofx\r\ndtig vhdp omuj vhpd\r\nfogwxim qvdwig emdiv jvhl euwbzkg xvxb hwmqo ujdmlp epmykj\r\nsjxll sjxll pedvgb sjxll\r\ndrvay gtzhgtx yrt okz nqf\r\nhaxfazn pvkovwb pgu tgshw mxcjf pbe nwoymzc mxcjf pbe hydwy jradcr\r\nprjsloa ahylvj okbsj qbdcdjt pmfo pagyoeg vkmhjzt khzmjvt opfm xfrji gyjqyel\r\nlzypt jdbtrad ogr jdbtrad heink\r\nrcoucuq gdxewa rcoucuq whlw zhhm rcoucuq azaqohe mzyli rdvaf\r\nyuag ebcf yuag nsotg qqzuxr jfmao vyucw wmoye\r\nqwvk xemm hgqrr wyxkpp tojndm xlvzypw jus bgnu bgnu nklfwhs\r\ndaqi knenmku ccm xkiuy vkexsbc kvvdagx umopitw yaocnx yoakqql mllmsp\r\nmrxgl gywit mfopia ncnsvw vdxek axuiot rsejua nei prndudz mnu\r\negqn gaa qgen urs mix zbn rhn\r\newharq aihy udkdaob kgrdd kgrdd kugbjtj fcef llqb pduxaq wcexmm\r\ndwtiw nelq hppad algxgf gcc upou akm efnb mxmhrud\r\nyxqaa ups okbhgt iet qns tqn rnjqxgp\r\nnpmhdm cgds ldexvr typi jyivoqk zkgq vfyxu xgfo\r\ndkwnmr umm dkwnmr okpjw wqx jpztebl eqsib dkwnmr\r\ndxbild wpbup evscivq dxbild dxbild geqp ojfbpl jshvqej\r\ncxdntxs csfocjd pyy tuhws teb boyloz xfw scxh pxhonky\r\nlteucke xrgwy hszgzu hnyrcvb\r\npfgsgwg dxzh fworek qbstod\r\nusemcrf psczxu gcjtr brls\r\nhjol efxczux bqdn gvrnpey yyoqse gbam ndzyj lbwb bhzn unsezg\r\nbapw xifz blupk qqdk bofvqpp wnbuwyt rnwocu lzwgtt zucag pov\r\nxkre lqvd juf lqvd xio xyg xyg\r\ntzdao ztheib aymcf aorg iyawrch hetcxa iyawrch czdymc ccv\r\nucgl azlppu jvxqlj pest\r\ndvwlw fuuy mnhmm okrp ualnqlm uyuznba fzyejk yaq crl ctprp\r\nodfq knox mkbcku pxucmuf lpjpol phl\r\nixongh hfs ruorbd auy qyssl kykwcix aytsm rlj aytsm duq segpqhk\r\nizufsk wedpzh podjkor eamo vqvev ifnz podjkor xrnuqe\r\ntwyfps bmdbgtu qye qkwjms\r\nwlav htym vhsnu cocphsj mdsuq vhsnu jflgmrp\r\nopajag itwjhfu purnnvk opajag\r\nhpkopqp vnj aialpt lzrkzfs nwucez nwuezc\r\nmcx hzcjxq zbxr dsx tpknx fva\r\nrlvgm xrejsvn ghawxb efyos xty wdzdgh olahbtn rga efyos vhtm nsr\r\ncni mbab qtgeiow ulttn rckc kmiaju jvbq emyvpew cdlxldn ulttn brhkprx\r\neykpffp rapik qki fhjgdyu tome ehjuy bibjk htxd vexvag\r\nwrk dpxt gwkuiov gbkif ike gbkif pcd wpj toywyf qzsa aol\r\nyqwzh uujn ujun ujnu\r\nsrs ralwxrz yxvvmgp sjhbhk waasid cqtxoxf whcladv jkmaq khjbsh dlavcwh\r\nmdvsjh xaj etvxlsy fxgiy rgjesel rlegesj ptriz ebdyhkp kugxm dxv egljser\r\nlhehwrs mqevb ygmv gri izop qgb ivm\r\nloqqam alojlwg hgen hbyw qlwpun loqqam worgnwk kope\r\nphozre todsknr todsknr ibj mvllsar\r\nwuripy ruwlfbh wukbkey qhq iishw tvtvci xawvxc vxacwx hsiwi ogq\r\nxryq vxwupqa zhqex aquxpwv bnvxrba dtbxki\r\nyvvwh zvsm vqskhp vqskhp ggqqlw bpn wbuv\r\nkqz tdy goqwge ygn jgd\r\nszjjhdk zkpoo nxexz ebicc\r\nwzuemcj oyd qupulju iaakzmt vzkvz\r\nnppahov umm wpzev wxkgfxd owgekp bhhb bbhh dgviiw kdfgxwx wryb\r\nbnc rhes lmbuhhy kwbefga bnc rtxnvz bnc\r\nani mggxf mcoixh zdd nai hbhzl mes bdpqr\r\nmjn uinoty jjegvze bjgqg yhqsxbt coj obylb hddude xqi rhfbhha alood\r\ncbjzj drmihy tfkrhsd nuhav hihzx bvblqpl tdd szmp gjgfv box\r\nuumhdxd cmwgyf vepr rwqdkj exwk\r\nhwvr ydvw bqefu kghes gvbhp awms iqsqes khgse\r\nmrey jqfw fwvzhps komj dayvs fbui zmtd cofn mrey\r\ndsjds fdpx irjj usndok qcctsvf fgk wvg txwxcl dxs llp zyilwtq\r\nxmkelgk fdukc cye legkxkm wwly\r\nenlny eynln cccku brkz dpof mwfoxcd yftmnqh wpebvyc\r\nggdn jnysl dsacffw ukj hdae cmzxku\r\nuqhm gcachmn kxndfrl htmfis jfnajz fiqiypr kekho kekho ndcw ckrndub dejfna\r\nkeazuq ertql rauwl keazuq obmh rauwl ksrotm\r\njppp poigqhv repfsje grjk xwkyuh pkx ayzcj hoxzv\r\nyhjw pcuyad icie icie icie hwcsuy wcd yihjh jnrxs\r\ngaug ivvx ceb xujonak hbtfkeb ttciml cctoz\r\ndggyyi dggyyi gqlyumf yasu fwdfa cbb nncn verhq\r\nrhgcw gpcyct kiuhbg kiuhbg gpcyct jlmleo nhumm\r\nwulxxu jyjek hclcp ogob viex wiqcupq\r\ntthu nxgzpid kcnj mss ukapgkp nnc bxjocv qwxs oejwsif aywqtu brahkb\r\ndtde bgvb smu vbbg zhlu\r\nlyo nwjjmep ldbok wgxhto wwuh qfgjknk wnsl\r\nlleyr onha hkwulbm jfg\r\nbybjwd uoxvbh mvj iqfpnxs bybjwd zqtszp wvc lbazjr zkzenja cev\r\nrbuyyr divtslq yuqmyt ajyveb smxsjb nlk tzqhq ims fewg wpjhr gqh\r\nkpewfd beq klilis klisli eeezut\r\neuqh hueq ldoo crqurv lvrwh tmaewp oodl\r\nbqi lzrf jyhvxfh bqi jyhvxfh nbztd lwpdn cuzi\r\nsrjylou phavzjd wost uxkaq byh sluryoj\r\nihrdk bcegkpq nygrs qbcq wyjg dvzme pgzhjl vibg kvv\r\nijsx iedemek ktlz gtga tbal lbki gtga\r\nvmiaxn kefig kefig vngxz\r\nvrdmfvi qts vlvhq vlvhq dihmq\r\ncfz dyrz zlw qnt vok fwvahg skshbqf hbwozdc ntana jdb uflp\r\nrimbj bxemw sfps krtk umta vnk ewmbx nrlje ymrtqrz mxewb kjxunbt\r\negnuti ozat eltl ngueti\r\nqtcwoxq rmaf qtcwoxq qtcwoxq\r\nzws gcoa pydruw qsrk lrkybdf ugr wkrxoj nyvf vitwn\r\ntmr hhd dojid zwrj bhsim righ keqlep flzunou\r\nlwoquvy acjowxk tqudk oenvioh nyavyl\r\nrgh dfhgyke iff cpxhuz hui koe iff hui dmukrei\r\nbjiumig lcbmbgh vleipx sfawua rnf\r\ngftfh qwb tfdroe xbno qhgofm vqfoe mux\r\nljdrr gyfggai iun nju xrucbis mhrcrh fukr obvuqc whlalfe xrucbis nju\r\nnxjmjr egqwg arllu xqaahri lzc ivt uhsti\r\nsqiepba rcmts kvesv nvp\r\ntiksw tiksw rjni gbhvzm ctbq zuqfyvz\r\nibsnm kfka aoqigwo sqouih rxz\r\njmymq lxio adtmk umyu sxvzquq bporqnb heol fow\r\nmepa eckq rqviawv dkqoei ifmngpp jiava rtklseu\r\nyuycd jiufjci yuycd uowg yuycd udq izkicbr csxobh\r\nnwu tfsjavb rruoxbn oepcov elxf rruoxbn rruoxbn azglwth jcjm ksqiqpv\r\ndthfwip zqnwa zqnwa zqnwa\r\ngso wruece ufl crgnlxv vllsm dpyfm wpa ctxko\r\nwvpze seodz lpq lpq pmtp wsxs ffppx\r\nyfxquj phvjn rtwieq rtwieq kgxztyu vbjvkc prqqd lyzmdo ojbrt ojbrt qiqjz\r\nesaezr rpggiy jey kbzrhu uthus osr xxaiijd qfxlf auhzbx gkigoqw\r\nyfhcj uvgck cds gjhhrg cmempgj yfhcj cjb\r\nyxi voxvtuw unwg jqqm\r\nigvjr ljz rus sru gbjtjt qfeg ztu zjl\r\nleof ocxns hbkoysh hbkoysh leof\r\nhab lyxmf yhh qeks fwhfxki xmbcak okqjii nfgzyg bhtfgdj lpmjn\r\nmgognh tad herere lvwnzx ixwqs zphmuuc etdjz kczsf\r\nmtej rlolsnn zbl uykek dpkan gmz etxtgj\r\nmihuieo emjgbp jgks mihuieo iexrfw mjdnr bvp mcuzea xkbusvi\r\njvqpj bwt jvqpj bwt gxr\r\nqpnd fpt tpor bibbpcg hmvguez wqc afl ckviua gpi\r\ndntmcg jglm sxtnu sxtnu sxtnu\r\nfzkbptw cbfwo ozvwov wbv gcdd izqo ovwzov lolewo xikqpw\r\nnkxyxzd kpn datf fki werq mwidqx oiibor zizcjph\r\nxvgyxym zor ijoy lvwsf fjuara idvvq rreit mqyyy ctio tzwqqhj rnpee\r\nmaqkfpk maqkfpk xukg sfdmnlg xjopvr xjopvr irf\r\nliujcd vnlkouy dxkwc gto vhjvtw\r\nswhqhj cas aupsd swhqhj cas bvbooii jquck dtdm\r\nigh iqicicf ghi pcxt srcrjx gmf gyscphv\r\ndrplj drplj wopgpnk wytag wopgpnk\r\nzexe ilcqoh qiefb txkuv lirfzv\r\novvpn ovvpn uqeurqx uwzn hgmucj ovvpn sjxulms\r\nrox silka irhsvym kutus otasof tdneav pcagds\r\nmkja omu tyshbfq onp trxs lxa tftbv bnpl djhnc zdqfs muo\r\ntjj rmmqas cbbkxs qio pikk ykyew gxlxt nhsyl ykyew\r\nfrcprg njrz oaxcmhc qben pedm ecvtga nzxwpb ior gaklot dpem\r\nzyt kncau spoe qlchg sqys wkpbng yflju qlchg vkve bzadbpa\r\nqtq pkaicl qtq mfkfqvr dnleiq brrjxsx uoyxh pkaicl yvmlug\r\nfirwy imtlp ywl qfa dqrbazz ztzb pcsbwhn zesmlag\r\nivey ivey mtvc mtvc\r\nlhize acwf moa cdeoazd voktshy qmvqq jvmuvk ljfmq tsanygc\r\nxreiqkc aawrovl pofcsg xreiqkc xreiqkc\r\ncjbzvn ozds iniqu sdoz gqmki bablvll krs vjzcbn\r\nizsod htkeqz entxn qtns prpcwu omfnmoy\r\nkwfb tctzda aztctd tadtcz gyt wunbcub ydiwdin xxk\r\nepnl ijcp giq ltfk zjcabve zfksmz epnl giq xxxbsom\r\nulyukpa mdjsbn dydko uhkdt qms aaaj hustlwu\r\nzlsbu ohx jcwovf egf zlvpqgx qhejm wrywdmw\r\nuhxqrzr mmu kjxcalj unuohiq rri yzngnb ikvlxry mfiym qbksdx\r\nkhqciz som yklmm jceb khqciz jspy jceb\r\nncwggv njvi nqox krtsn lnm\r\nbgtqme xaxcoq qbtgme obqual vorfk baoqul lgrb\r\njli tsbb nlxjc pkwzmz dlxrj hmho gzguko ilj iyaasm\r\nwlmw grkumg dynwtyo emxhhqr huluk slpqu uhqcmd absmr ufirmwr\r\npbs pcammxv dplfr tzvmav nccyy blvyq ffhnz bccutq\r\nhgge ghge vxmvz hqxgjdg zab guo gheg\r\nylj bucoyoq udndc wpgyrbx ueh udndc gxdsdh hdoz wwgqlg\r\ncjdeh gttyqe kdkm ltzd lfeozse quvjq mnwhokm kdv oojxm nxt\r\nmfkzus knqxt saxkqww njx zumsfk sbmcyad cpt agvbuv\r\ntukn vyco yobvsn bzgnn klrnzy kea thzk pxpwq ryfff nxzm\r\nylbm lxlz lybm lzxl\r\nwgtxoij zad slgsi cvnxfg iomswwl vmx\r\nhkm yinhnkj kmh kwkw kayknck chur styjif yknakck\r\nrtfwhkq rtfwhkq zsf zsf\r\nsldq zlntr ueegiw kajivqc ozcbm ceft snvugom pdyc elppeed nnqrp prwwf\r\nlhk xjonc muc tudag tsafx mmivb dvrjbp qgrew\r\nhnzer fbgqp aazta aazta lxaz lmgv aazta\r\nvictgxu victgxu mlpd ummrnbx cazjgnw isxcyp efy zfa cyusj\r\ngyojxo onzq gyojxo uxufp awi ilhl wefwfxr gcjlt tmliynw uxufp pdcnxah\r\nwjwachn xkuhfbp oky oky ybaeqkr rbuix yreoaw wepmye brvon aasb\r\nkiidorw vxtxiqx wtqvbrv efdth isel qbom vcssyc vxtxiqx wtqvbrv riafzsw mqzsj\r\neurpjd vkhdamt tmfx czeoot hiz ykz lmixzq tfur jhzr\r\nipuftpj qbll sqkkdw fwncmiv bri oeeh lehd ioh wag\r\nsuima nanngc imrmc krq atxdo woy atxdo akev qlr aezco qlr\r\ncfc efwbzck ozkmcxv moczkvx ccf\r\nbnekky iakrk sask uwgnjp iyi rynev bdnas ldh kass\r\nsicmw vvjbvv cap nsumc xgvrlm wsoo uoqdu psykckm\r\nugg mtr wnzhmmh tjxc ehwnji lwhu mdsckk yvmk enubrqo\r\ngrb oxmxz ohu ytetedv ssx apzlppg fdkamm sxofc jdt ynmu wyejok\r\numoep rbyqm eqfk twqnog cptbbi dragna ngqs ffb cexxnc rbyqm\r\nutizi ormkel wvwur bdx ecelqbv xiccama aag glfvmj\r\nznb rsuqoa uxo svc\r\nobs lbifa cffi catpd\r\nqkxwian ajlzjz wewduzp bbyv qmt fsr qgiu epinp ghmf\r\nhatg bfgmb aght ghat\r\nkuq inp dun cknbun wmwsu drlmmg kyxc bdl\r\nbddybth swdbf jhi fva qpobio bjwm wjaztp jywi\r\nmgckz vhveu zkemhp zdf xtiqqew mlx wazgd\r\numbjq pya lvvxf jeavij rhrxvew bwjqgpr piz\r\nxaycpwo vjcuc qksc yuixhni sfbfb dydyaq gdfvb tggg xidphvf bpjdrl goskxym\r\nagxfoip gguif wvo agxfoip ntkbaw fbyggy ooft zxih\r\nnzvsu ffwq uxvfbl qrql olhmhom qhdltg ymwz krtndtx olhmhom nfsv krtndtx\r\nqdp jqk ustz xjripzv mnk grnodk pjwdsj uug zqxjqj\r\nmufrcox zunisfs ocvcge acamm xua vor bsde kxr vor kxr orccxx\r\nncycbp anvcxay bmm wndmeaw oso knmk mmb wamenwd kmkv ppdd\r\nmotdcn xzagzwu vuzt utffrn yuqxzrh uvzt ujttq\r\ntauoqy coiy ybesz tauoqy wpmr trquyne ahxbj jzhems dsdy\r\naczq ypw pgmzz srfn quatjgf\r\ncih ypapk bfxvr euvhkk gugru auhqui\r\nvyf pssgfvy dnhvbfl xpacme dnhvbfl mzdv iynq hcqu\r\nlbzvbu hhxiq hdfyiiz iyzihfd xhqih uzdqyxr\r\niapbdll vdr cprmrkk vdr dfjqse mlry flpqk vdr\r\ngrrfkq xcpxd grrfkq dxc bjpr prvwh swoc swoc\r\nbopo chvwuhf qhd ieesl xey ieesl fnjcbe\r\nkic fyq hsucnu agwyl pzzmd hqksh psw\r\nmxf uau iti lcoz lpg zbu ocre wqlocmh mxf nidqj lcoz\r\nbypmix ptzxgmf xmtzgpf hrvzzq\r\nlbfw zwusma lbfw tuyyy\r\nlrf uej unswvh obgsb npbl zajr kenea uej qnyjcu wzufim qpzkgya\r\nqcrxj llyu kligt hlm ehwtbx dda lgsvhdt xewfcv uikn\r\nnfzjx izqdbq mfbxs imiuc yqxb xlmvix izqdbq eflqfq wku omgtuu izqdbq\r\nlasdwg hiy btzt eefd eyoep icn nnmhg otml rek luixac nyzgn\r\nvekteds utsuxdx utsuxdx vekteds\r\nfeyov qrij zbebwg ijrq seplram wttkwm zewbgb kzuhuh\r\ndmkgtv wohgqo ddtqmv zatahx mym hqowog tkmvdg\r\nvhha wjrmuyx kqh vyyrj xzchbi ejsdq orlxg vyyrj dlrc\r\nyetngqn zdtuqox hkarjei fqpsgh eaqwbg zsssog ghb gddqqzr hbg\r\nobldb zsrhz zxp uxphnev mwnbc pfjft fms xwslk vjm fxy\r\nnfij dbfykv ttq gyjgac igxuyqi gtiioqx ilhdex dbfykv uyp bdiwya gqf\r\npffzruz vogfosh dcs wje\r\npohhf fhpoh oon yyz\r\nxxuam afwm qxl lnt syyr bwxhhf sozauq shlhfmz kwnn milav ochq\r\nwefcqrt gejw cwerqtf fttf gjew\r\njfsvnmr osca epwtle pgfif sxom\r\nexlfzmq nakp rgdnx rrcvth vhrrct aajjdrt ryyg dsozd jdqlqj pakn iruv\r\nrmcvo txszcs xxhyxz hbsozk wshkocf rmcvo rcbnt\r\nkitz yjgney yvkymef nauj hmllsgl kyhm kqr pzsu rcf pzsu qpte\r\ncdinpx bfur mkj naz ihkheyr nohhoe\r\nylris xeqcgup wap bbfih tgfoj\r\nina gnlnm zyeqhij cudfuf ipufae bvkdzni aat teqsg cudfuf bjokrbl teqsg\r\naedx edax dnfwq qndwf\r\nrdngdy jde wvgkhto bdvngf mdup eskuvg ezli opibo mppoc mdup zrasc\r\nqcnc iaw grjfsxe gnf gnf\r\nzbjm snznt zelswrk gkhlnx dqxqn qqxnd dmro\r\nzisecvx ztezof uzbq otnrtj qsjzkwm ewvcp rlir bfghlq tgapdr qxmr\r\nipnqj opjf vabyoe wkwnd\r\nwyf mfqxnrf apm snarf jqu aaghx pwecbv lvghayg\r\nacncv jmmbwlg oiphlm ifuo cvt\r\npvmb egansnd zmh gcuzzci rrxpslv ubith\r\nuoleptg xbouzn xbmg cfh cpn wpqi xbouzn xtxis sxzpns\r\nrilybri kurbpq vfmjpck tjyogho hfyxad svfofx lfbbhxj khaerfs iqr\r\nseaebgz wlmtkre qguv qguv wlmtkre\r\nsgo edkxya zdqgwtt gxu nibuu rairqoq mzxli dci qsv\r\ntsol mdhzqr rmaqnru ggvcq arbwkn hlkcnj ljkcuof\r\nmmliphp ocup puoc eijjv\r\ngmajqpb ijki ijki kvz\r\npmqss unhlpcj dlkll nuhlcjp expe tlurzmv nsy vlumtzr tgseozl\r\ngkvaoni hsba hsba viuedv phyoclp fdq phyoclp febld nqfs\r\nrxvdtw abn pntv qrqfzz slsvv abn lrxix mnu npot\r\nghlfjp woy xwkbmv bkahpkj jve cncvk jvdype fwgvoju yrkwjp gwfvln mvkv\r\nkmluh mie bby fwer chsinb ojglqr nqk mie\r\nyzmiu igkgca ybnsqja jpfejtp yjddy xsosxfi ingx qwuhb emrkwpx idqjmmm\r\nbtrllw mphm dkvo ewdl dchcul yah btrllw kmqi mtvgk wtb\r\nhxsgard yuikc lykt tdee adprp gpougod klnzk mzsmlb\r\nhdn znblw ifoblur bwzln dbv\r\nsmofpbs vjuyiro llk lfzesga tybu tybu\r\ngffnpug xaup iqiyz fjkpnkz drrk fwyxw lwzfskz gslwpmv vjxylva tbkyo nib\r\nevydmb nhwuiiu fkerq nkgbuyy uclrs ydjgglh xhotwbm riirgzt\r\nbsub eavbt uvd dpzwyt rhn khrbptt xszckc djnfxju axofhat powmso nvdffrv\r\nxtuykl fjz mbikc xpnx hmey fjz fjz\r\nrkls nwdcsyx rkls rkls\r\ntygml untequ ybdfumz nqffbq uipc sove hfnqj\r\nytecew vven koqn royynd qsn ksl qsn sdw\r\nhknlw qwho whoq oqwh\r\nlzmmtqu qvhyeo cnofuj utpwkjz gnirz yhhu aodbnd\r\nzsr axw kwtzcv tydzo kwtzcv lkxsm\r\nrbjtqe nihifd gvdxd bpxzy rxteky vgcgllv vbbua anygiup rqo\r\ndpd wblfwp wblfwp wblfwp ygahc tqjbaq\r\ngsw gsw pacgj xmrcz zmxhmch xmrcz\r\npdq rhe xqmq lgpkhg fyffrot ovnqh wle\r\ntbjavke ypzzrj jizx gdxoh icjsat otfh fmygumv\r\nsnch nxlgjgp jeyn sxoqfj jtage jtage iuice\r\nrtb coefuj grwg grwg rtb krhqnma vfhgbr\r\nvhegtl btorwxg szcev kbvkx itsk nlzpbed\r\nhiukrf ilzkm yllhh xsgwkdp zyy kjbv\r\nrfcg tdorci zcj wzftlv rfcg rfcg\r\nlgbc lzizat vsno pau nvv vsno bbr lzizat qhtb gwp\r\nsfwnio tcugjk bsfsz ykyfwg ibkap fsrvy mygk kzunawx zyhyh\r\nmpavlh qps bylh lttjkz rqabgk vewb bwev tlzkjt gzrbxga ktmso prpkj\r\ngpf ims ynh ffrs vpa iemp gofh cgbauje\r\nsecys qks mcnfhwh drog kqs pajy zoltkw lfihnb myb ioxptu\r\nytq nrta ouk ajqblf yuwwcd zdy blyoxbw dakk nvgi bzrhzaa\r\nnkoych sufiia xkdvw crtldee zycl qblab egqhr qblab\r\nnllno muxaf vds qjnitmw zkpj wskyhft kmqct xamuzpw qcai cdjtbt kaxv\r\nqzdytpe osr fuw osr qzdytpe whperd rydwdcl knoa\r\nzkdznhd peh duoygr zamrgl irnvj otpe pltpq jdkecg\r\nbyzgw rece iigdug ehif tpgje\r\nccnn foqdran gbctca tefdjxh ntcr rjciii xip xlss crl wvvhzqm twyohf\r\ndqyii milqqc qjgkojp qjgkojp ryde\r\ntdkyj tbrcud tsba vqtmb cjwxnf\r\nhqhmq wemvrce nagig pwnw nagig epg nagig vlsi\r\ntqgvw luoplw hccti npjm rytdruq cylrsun rytdruq vjsbjl rytdruq ppti\r\nitgt tuwc itgt rvp itgt tigns eipl ksmru\r\npdw wdhtkn nbdbpn wff zhuuipg rvemv qxr\r\nqgkwdq cjilayh ymeks mrpuzai dwgs stfstgz ucvqhb yout oiq\r\nvpxik ypfr qytimvu qms oxbmw ppyfx\r\nfwwidn gdhd pyuexk snsz iwndfw\r\nlfcb sllxjna lfcb hpzahfg mmvgaa svny jhuzd\r\nunyg gicmzd fwc spkciy toyq wjupckd vzzx iuqgka ytqycb pxsufj\r\ngoj tnrcml eyizngj txa xrkiw zvu igduz\r\nwek xrrlkna clyof rrlnxak\r\ncjm rmyuku vjom gtf\r\nbuk cfae awstd dywgqp hxo wcxvf laihqw xdqfes wdbh qceh uzlwj\r\nsudguo dxwplto rlebdh bkamu dxwplto\r\ncrwkyxm yuz kjtdhom crwkyxm\r\ntrhc sduorxr aizfryh rsudxor gbyc\r\npczkyl bptp qnn nxmpwsx udrg hhlb rubtrmx twzodlp xygnht\r\njmqct cden yfajtkz fevcw sxonbxz sxonbxz qkzkm hhngr fbv\r\nsdsnm mwvicr wypfi cty ndbowr woiz mrauwzd qlno mwvicr\r\nvteyo fng lvr lxytn txpj milg\r\nwjx ahtmgo cgwcaj kaxae fhlvlqf\r\nezj eetqhzu upwda iiefwlk vyvby\r\nimalvy yeghqe jwcu mvrod cwju\r\nbxnmsa yhfu npsdar tsbri hfuy sirbt oofxmy\r\nfkndt elbjtn vepqtxt elvpf fpelv bzkgag qttexpv prblwb\r\nrmq iqs yvprnyy iezqrzm wlqsrr\r\nyviovq lekxghj oey qwhzj lxknxw qiyovv ksnt jptz\r\ntyrg cifxt hugqf tyrg ffuiv jmax qyw fozfosq ffuiv\r\nnmg rsl jpzazd qbtlf yxqtsj czwmdfd bamge lbjdof uqy jssc\r\ncbx boozjip pwgvzlq rjz kxy kxy hszacok fvsq jhnir cnsba gafz\r\nsbcuxb wfur nnnfqjj fdwg huhe sbcuxb\r\nicwk qelbxs uevp qped zsnhh wpuok wddxsln ftnzupr ruxol cgxjb jbhh\r\nizcp htykj xxmndoq amnspe htykj\r\nvverol oixwlny vqd tvfzu henc gnyrwr\r\nytxio etytsx choynep zqapo hfjit\r\nlkvgr oyzfa taiqr jok djatvy ckif tmdw oyzfa zroy\r\njlgpyp kkqysg oqjki hjohoug hbhta muilz zft\r\nsumfyu wftcu bwwdcy lezimwa qwvxv zwh mqyv bmfot aii torcol rnt\r\ntpdj xrw ccsbnh fhptv fwkxjfm dmqaokd bjci\r\nzxi vmf vmf dpyg\r\nsfzxysw lcms bkojtv bkojtv\r\nopywo qll ipkitr mtwp tudrr svhyp huz bxsdpn xomfy\r\ngkod luo qrosbp orbd rpsjzyd rlh gdok tze\r\nnusiuq nusiuq zeys ahufexc\r\nveno jntg avtmtdn qojxru zegdcql odfcetz pgehau\r\nuqun vigjm ykac ozlelj danmji bibugox\r\nrpuozh ajwru rbvuevv uhzsq\r\niawoe tyb aewio ymf byt inijv ctu fcys micsgzl pbby alt\r\ngktyxp ris mqpfm bkqsfl nrg idbbcxg jhcf\r\nqibt invvv qibt luitx rnm eby hrfbmwl wnap sgkzvb qlwc hrfbmwl\r\njwkv qecsjbw lycgldd wjvk tjcp dycldgl pzrvr zrlcf kji\r\nnzsrmiq nmhse ilivrk kqv\r\nbesmyzi imkgpt iekbjax abxeijk uvzs wwv\r\njdocl uki ltswp tjkljc ymce iuepze qygqxzs tei lkry\r\nhhyfy gvzd mqksxlq czn afe mesnag eep frwgekg mqksxlq phpy\r\nehg connnza ekt ddgokw\r\nmpbsoms uzhzl xevww ztt uzhzl\r\nlftybr firc awsud dsxdkk ltf ipjv dtx lcymth\r\nvkcpb gxtxq yioeq fexj xxgqt\r\nsrvca fslnnvf nfmkpvt egw wemumq jie vznf dzsjw cukf kcvyir\r\nyxjkl lyjkx jyxlk kgc xtz\r\ntpoe xzov csp leleoqo noyre tdhf cyib sjgtdx raehdw nmcxp\r\nqvt uhznqe bpvos vtq ddlebtd tqv\r\nxlw utsxs gpia rvlvnts elkxr dddihy tnrslvv ibf wlx bxg\r\ncwqnnrt rkkqyf dye yde fzl pthanj\r\nboc rqjenpp xjqte jteqx pvoofc pidqe ruoucy gvnro ognrv\r\nqhalb gnazwc fhl iuti\r\nclnbjfo nnfs nnfs heymvr oarew oarew nxu\r\nlwtrotg hiaxwj ymzbly nvhzjhj zlsaheg nvhzjhj ymzbly\r\nrrvi tsjp tsjp tsjp killji\r\nrpx hiclj cmwq ibhj nfd\r\npvwymn iebkd xmpw vuhhkap ksw zigzy mzzyyxy rmuh iwwhea cglfq\r\nrlwelgy sffml jin qsdzro xlsty mgqzuu etxjuo emzd jgnoyq tkjuy vfvb\r\ntkctdj hhkuc viskmy obw\r\nzvjkuj akeky ikj jqd hfhzbwe bkc\r\nbtev nrdo hcyiuph stf qharfg vpmel mpfz nvs ytgbbc\r\nieepn ndueuw svmdr tcvumw mceyrn mrjwhyl tbdj mgrgvz\r\nuxrs ckyi xpmqm czzrkl cjp\r\nnlliwd wrqkrkz yjmng nlliwd zirde hcjjn wco ysf mgl\r\ndxti lcahe ommare izlwf ramsfb nzgfvo ijvm fwymrdu bndq\r\nisxy jpvuzu tdduyhw dixp cfa fkzbteg ytoi kepk ysf yqcpi\r\nqmeprfj soqo ncgeor cqsuuj grzy wogxy vyblnbg slvtry vdols kka\r\nltykfp gtzl olrp gxend vapee deq\r\nemywfbn dbfiut rkt wvwe dbfiut bwffhea yuzcxv gogpicp wvwe\r\nvqvmrp ofbk dlfabd jwllzxk obx vqpwjj umvng tqwis fstxy fstxy\r\nmiha zgvyux rmraszo xwf\r\nkjaagk btm kjaagk wkewjrg kjaagk\r\nlbmli aizs omrdr gzktnx asiz ptanzpa xlo ljre ckyb wob\r\nsvz dlk rijagg avxmg fkzwhk uro gegm\r\ndzplum temdw jqnm tvxcww bmg tftttpp deuw comxey xfimzjx caluczi nqn\r\nuwvhxa ztkd nlsdyt vihl julkwwv uzch dwakhs\r\nwkhuihh ycrc cxff vzcfhpp uegfd gaok kcnvz lhzogq lwa tyrypvu\r\nidp zmrrzp zmrrzp nktp xsnx rjsxn\r\neybrnib ivgntl vaxsbpi eybrnib\r\nnzvnq xvbfa pbhwwh ylju runvsj imlx vztesn\r\nnfdohd nfdohd gtevnky pivjyct ihvd fzcsrq lko fmqk\r\nkwpkks ecikxu bcxswlt qvrxm sbcqmh\r\nkdjrmj piuh kdjrmj vnaf gyedkg vptxgm xezssxx zsg qjzpo zsg\r\noqo sley aqx qmpqb fgmylbj egd zivj kepxizv kuakyn lunbnd\r\nhmcf hmcf xlhgc hmcf cdlm buofnx\r\nonjcj yluonz kzmk phqo phqo phqo\r\nohaafy efl bnkkjww wwjnyoj dxeaig ywnjjwo slk hrbebw ohlyju elf\r\nmsohiqz aunk njki bfktdgi htmyrj mgx\r\nnumlzrl rmnlulz glb ltt fhbajz gqxpu\r\ngko hco oai ryq xwy sdqosft spjkiu cxfhg ycwpglh noy rah\r\nbtzpjem brpk vqr atxu rhlh rqv jmg fvyus\r\nphmxxgj ejx xje qtk hsb kqt npwj gqt\r\nhujyjp nwmsd ant zipuya lrkahww uwqal vzlo qmbo twkjkse ufivi\r\nzfbnyz fwvh xrnrw usn zin daq iwjzj\r\nyykyg iwypfy hehqnl cjvk cevdrec\r\ngui muuto wsta glqmx gfo rdmbv mxwz gffzt eejpw gion\r\nlpng nduid iqbpu nduid knrqd\r\nxwxn oefpckv gjaua ugaaj gjuaa\r\nqxk aeql trqdmqc crzlinj crzlinj trqdmqc rijcne ewyf\r\nrfv qmbe fvr bmeq\r\nupqyfw lowzq wpen upqyfw gfskbil sljuzh wpen\r\nbdcara qyhx rtaez qyq gbyr\r\nevzls qxtxq clzd svbgqi zxlzgss vtrre fko eebo qjyl\r\nzaapeo kpwhz tygknau nyd pch trp xqe\r\nypzcafg rnqmbh qtteg sncu ssojhhm zonfym thir xmgheb wqj gpjg ssojhhm\r\nwvcwyn xrf muozyya lasdp xpjgu kpqv zkiihiv ifje cbdlavg xbied hfnaa\r\nqqqb rettz rycukl ihpkhh\r\ndnxzxqv znb znb fbxj azxtezb xvxa\r\npeqkd xlzqkov esgnw ucku hrwpfxd xtd vnig vlmfp ajte qswr kqoj\r\ndpwy oavzkk dwyp ehij upqxgii pydw\r\namfc hfv xmqa nqvn cal rqmcq oej amqx cla ntxj\r\nhqhhe qkbhwli wmhlcq xaczs peywuo\r\nvcr xfv xfv kymo qpszwzo xfv\r\nnmrbur tswo xbo ljlrzo bmhpgc pev zovkznz lok wbbhtkk\r\ntojj lxqgr rhjavrm ndsdup gdbjwaq cqpnl wfaxivl rfry ryfr udspnd\r\nbeffod sknlph amb feobdf\r\nmldgn jxovw yuawcvz kzgzwht rxqhzev fsdnvu vluuo eycoh cugf qjugo\r\ntlnd qcxj ker fdir cgkpo nrqhyq raef uqadf iahy rxx\r\nmhvisju lhmdbs tcxied xeidtc ujry cditex gvqpqm\r\ncgc jazrp crgnna uvuokl uvuokl uoiwl sknmc sknmc\r\nrvbu czwpdit vmlihg spz lfaxxev zslfuto oog dvoksub";

            List<string> passPhrases = FULL_LIST.Replace("\n", string.Empty).Split('\r').ToList();

            Console.WriteLine($"Valid Passphrases - Part 1: {Part1(passPhrases)}");
            Console.WriteLine($"Valid Passphrases - Part 2: {Part2(passPhrases)}");
            Console.ReadKey();
        }

        private static int Part1(IEnumerable<string> passPhrases)
        {
            return passPhrases.Select(passPhrase => passPhrase.Split(' '))
                .Count(tokens => tokens.Distinct().Count() == tokens.Length);
        }

        private static int Part2(IEnumerable<string> passPhrases)
        {
            int validCount = 0;

            foreach (string passPhrase in passPhrases)
            {
                bool isPassPhraseValid = true;
                string[] tokens = passPhrase.Split(' ');
                for (int i = 0; i < tokens.Length; i++)
                {
                    for (int j = i + 1; j < tokens.Length; j++)
                    {
                        if (IsAnagram(tokens[i], tokens[j]))
                            isPassPhraseValid = false;
                    }
                }

                if (isPassPhraseValid)
                    validCount++;
            }

            return validCount;
        }

        private static bool IsAnagram(string a, string b)
        {
            return a.OrderBy(c => c).SequenceEqual(b.OrderBy(c => c));
        }
    }
}