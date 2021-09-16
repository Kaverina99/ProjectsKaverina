<?php

namespace app\models;

use Yii;
use yii\base\BaseObject;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */
class Order3  extends Model
{
    public $nameOrg;
    public $addressOrg;
    public $codeCity;
    public $fax;
    public $FIO;
    public $position;
    public $phone;

    public $count;
    public $klimatIspolnAndKateg;
    public $temperOkrVozdukhaMin;
    public $temperOkrVozdukhaMax;
    public $classVzryvoopasPomeshch;
    public $naznachNasosa;

    public $raskhodMin;
    public $raskhodMax;
    public $raskhodNominal;
    public $davlSistPeredVkhodom;
    public $davlSistPosleNasosa;
    public $naporPotrebPriNominalRaskh;

    public $kavitatsZapasSeti;
    public $namePerekachProdukta;
    public $obyemKontsentrTverVkl;
    public $tempRab;
    public $plotnostPriTempRab;
    public $vyazkostPriTempRab;

    public $yprugostParovPriTempRab;
    public $toksichnostPoGOST;
    public $classOpastPoGOST;
    public $vzryvoopasPoGOSTR;
    public $pH;
    public $polymerization;

    public $material;
    public $rezina;
    public $chastotaVrashc;
    public $podacha;
    public $napor;
    public $kavitatsZapas;

    public $KPD;
    public $moshchnostPotreb;
    public $typeElektrodv;
    public $ispolneniyePoVzryvozashch;
    public $moshchnost;
    public $napryazheniye;

    public $chastotaVrashch2;
    public $tiporazmer;
    public $zatvornayaZhidkost;
    public $akkumulyatorPruzhGidravl;
    public $holodilnikYpl;
    public $avtonomnyyeSist;

    public $agregatInPolnomObyeme;
    public $nasos;
    public $massaAgr;

    public $zakazFK = 3;


    public function attributeLabels()
    {
        return [
            'nameOrg' => 'Наименование организации',
            'addressOrg' => 'Адрес организации',
            'codeCity' => 'Код города',
            'fax' => 'Факс организации',
            'FIO' => 'ФИО контактного лица',
            'position' => 'Должность контактного лица',
            'phone' => 'Телефон контактного лица/организации',

            'count' => 'Количество заказываемых уплотнений, шт.',
            'klimatIspolnAndKateg' => ' Климатическое исполнение и категория размещения по ГОСТ 15150-69',
            'temperOkrVozdukhaMin' => ' ',
            'temperOkrVozdukhaMax' => ' ',
            'classVzryvoopasPomeshch' => ' Класс взрывоопасности помещения по ПУЭ',
            'naznachNasosa' => ' Назначение насоса',

            'raskhodMin' => ' ',
            'raskhodMax' => ' ',
            'raskhodNominal' => ' ',
            'davlSistPeredVkhodom' => ' ',
            'davlSistPosleNasosa' => ' ',
            'naporPotrebPriNominalRaskh' => 'Напор, потребляемый при номинальном расходе, м',

            'kavitatsZapasSeti' => 'Кавитационный запас сети, м',
            'namePerekachProdukta' => 'Наименование перекачиваемой жидкости и процентный состав ее компонентов',
            'obyemKontsentrTverVkl' => ' Объем концентрации твердых включений, %; их размер, мм',
            'tempRab' => 'Температура рабочая, °С',
            'plotnostPriTempRab' => 'Плотность при t° раб, кг/см3',
            'vyazkostPriTempRab' => 'Вязкость при t° раб, мм2/с',

            'yprugostParovPriTempRab' => 'Упругость паров при t° раб, кг/см2 (абс)',
            'toksichnostPoGOST' => 'Токсичность по ГОСТ 12.1.005-88 (ПДК, мг/м3)',
            'classOpastPoGOST' => 'Класс опасности по ГОСТ 12.1.007-76',
            'vzryvoopasPoGOSTR' => 'Взрывоопасность по ГОСТР 51330.5-99',
            'pH' => 'Показатель рН для водных растворов',
            'polymerization' => 'Полимеризация, кристаллизация, и т.п.',

            'material' => 'Материал, стойкий в среде',
            'rezina' => 'Резина стойкая в среде',
            'chastotaVrashc' => 'Частота вращения, об/мин',
            'podacha' => 'Подача, м3/ч',
            'napor' => 'Напор, м',
            'kavitatsZapas' => 'Кавитационный запас, м',

            'KPD' => 'КПД, %',
            'moshchnostPotreb' => 'Мощность, потребляемая, кВт',
            'typeElektrodv' => 'Тип электродвигателя',
            'ispolneniyePoVzryvozashch' => 'Исполнение по взрывозащите',
            'moshchnost' => 'Мощность, кВт',
            'napryazheniye' => 'Напряжение, В',

            'chastotaVrashch2' => 'Частота вращения, об/мин',
            'tiporazmer' => 'Типоразмер, исполнение',
            'zatvornayaZhidkost' => 'Затворная жидкость',
            'akkumulyatorPruzhGidravl' => 'Аккумулятор пружинно-гидравлический (исполнение)',
            'holodilnikYpl' => 'Холодильник уплотнения',
            'avtonomnyyeSist' => 'Автономные системы',

            'agregatInPolnomObyeme' => 'Агрегат в полном объеме ТУ',
            'nasos' => ' Насос (неполный объем, перечень)',
            'massaAgr' => ' Масса агрегата, кг',

        ];
    }



    public function rules()
    {
        return [
            [[
                'nameOrg', 'addressOrg', 'codeCity', 'fax','FIO','position','phone',
                'count', 'klimatIspolnAndKateg', 'temperOkrVozdukhaMin', 'temperOkrVozdukhaMax','classVzryvoopasPomeshch','naznachNasosa',
                'raskhodMin', 'raskhodMax', 'raskhodNominal', 'davlSistPeredVkhodom','davlSistPosleNasosa','naporPotrebPriNominalRaskh',
                'kavitatsZapasSeti', 'namePerekachProdukta', 'obyemKontsentrTverVkl', 'tempRab','plotnostPriTempRab','vyazkostPriTempRab',
                'yprugostParovPriTempRab', 'toksichnostPoGOST', 'classOpastPoGOST', 'vzryvoopasPoGOSTR','pH','polymerization',
                'material', 'rezina', 'chastotaVrashc', 'podacha','napor','kavitatsZapas',
                'KPD', 'moshchnostPotreb', 'typeElektrodv', 'ispolneniyePoVzryvozashch','moshchnost','napryazheniye',
                'chastotaVrashch2', 'tiporazmer', 'zatvornayaZhidkost', 'akkumulyatorPruzhGidravl','holodilnikYpl','avtonomnyyeSist',
                'agregatInPolnomObyeme', 'nasos', 'massaAgr'
            ], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['count', 'integer', 'message' => 'Знаение поля должно быть целым числом !!!']


        ];
    }


    public function order3()
    {
        $type3 = new Type1();
        $type3->nameOrg = $this->nameOrg;
        $type3->addressOrg = $this->addressOrg;
        $type3->codeCity = $this->codeCity;
        $type3->fax = $this->fax;
        $type3->FIO = $this->FIO;
        $type3->position = $this->position;
        $type3->phone = $this->phone;

        $type3->count = $this->count;
        $type3->klimatIspolnAndKateg = $this->klimatIspolnAndKateg;
        $type3->temperOkrVozdukhaMin = $this->temperOkrVozdukhaMin;
        $type3->temperOkrVozdukhaMax = $this->temperOkrVozdukhaMax;
        $type3->classVzryvoopasPomeshch = $this->classVzryvoopasPomeshch;
        $type3->naznachNasosa = $this->naznachNasosa;

        $type3->raskhodMin = $this->raskhodMin;
        $type3->raskhodMax = $this->raskhodMax;
        $type3->raskhodNominal = $this->raskhodNominal;
        $type3->davlSistPeredVkhodom = $this->davlSistPeredVkhodom;
        $type3->davlSistPosleNasosa = $this->davlSistPosleNasosa;
        $type3->naporPotrebPriNominalRaskh = $this->naporPotrebPriNominalRaskh;

        $type3->kavitatsZapasSeti = $this->kavitatsZapasSeti;
        $type3->namePerekachProdukta = $this->namePerekachProdukta;
        $type3->obyemKontsentrTverVkl = $this->obyemKontsentrTverVkl;
        $type3->tempRab = $this->tempRab;
        $type3->plotnostPriTempRab = $this->plotnostPriTempRab;
        $type3->vyazkostPriTempRab = $this->vyazkostPriTempRab;

        $type3->yprugostParovPriTempRab = $this->yprugostParovPriTempRab;
        $type3->toksichnostPoGOST = $this->toksichnostPoGOST;
        $type3->classOpastPoGOST = $this->classOpastPoGOST;
        $type3->vzryvoopasPoGOSTR = $this->vzryvoopasPoGOSTR;
        $type3->pH = $this->pH;
        $type3->polymerization = $this->polymerization;

        $type3->material = $this->material;
        $type3->rezina = $this->rezina;
        $type3->chastotaVrashc = $this->chastotaVrashc;
        $type3->podacha = $this->podacha;
        $type3->napor = $this->napor;
        $type3->kavitatsZapas = $this->kavitatsZapas;

        $type3->KPD = $this->KPD;
        $type3->moshchnostPotreb = $this->moshchnostPotreb;
        $type3->typeElektrodv = $this->typeElektrodv;
        $type3->ispolneniyePoVzryvozashch = $this->ispolneniyePoVzryvozashch;
        $type3->moshchnost = $this->moshchnost;
        $type3->napryazheniye = $this->napryazheniye;

        $type3->chastotaVrashch2 = $this->chastotaVrashch2;
        $type3->tiporazmer = $this->tiporazmer;
        $type3->zatvornayaZhidkost = $this->zatvornayaZhidkost;
        $type3->akkumulyatorPruzhGidravl = $this->akkumulyatorPruzhGidravl;
        $type3->holodilnikYpl = $this->holodilnikYpl;
        $type3->avtonomnyyeSist = $this->avtonomnyyeSist;

        $type3->agregatInPolnomObyeme = $this->agregatInPolnomObyeme;
        $type3->nasos = $this->nasos;
        $type3->massaAgr = $this->massaAgr;

        $type3->zakazFK = $this->zakazFK;

        return $type3->save();
    }


}


