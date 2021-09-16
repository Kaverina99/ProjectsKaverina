<?php

namespace app\models;

use Yii;
use yii\base\BaseObject;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */
class Order4  extends Model
{
    public $nameOrg;
    public $addressOrg;
    public $codeCity;
    public $fax;
    public $FIO;
    public $position;
    public $phone;

    public $count;
    public $markaModNasosa;
    public $proizvod;
    public $markaBPY;
    public $climatIspolnAndKateg;
    public $classVzryvoopasPomeshch;

    public $tempOkrVozdukhaMin;
    public $tempOkrVozdukhaMax;
    public $namePerekachZhid;
    public $tempRabPlotn;
    public $tempRabVyazkost;
    public $davlNasyshchParol;

    public $toksichPoGOST;
    public $classOpasPoGOST;
    public $vzryvoopasPoGOST;
    public $pH;
    public $polymerization;
    public $naznachNasosa;

    public $chastotaVrashch;
    public $napravlVrashch;
    public $podacha;
    public $napor;
    public $davlInSistPeredVkhod;
    public $davlInSistPosleNasosa;

    public $sushchProblNasosa;
    public $nameZatvorZhidk;
    public $davlMPa;
    public $temperat;
    public $osobTrebovan;
    public $typeElektrodvig;

    public $moshchnost;
    public $napryazheniye;
    public $chastotaVrashch2;
    public $BPYpoln;
    public $BPYnepoln;
    public $trebpvanKIPiA;

    public $zakazFK = 4;

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

            'count' => 'Количество единиц, подлежащих поставке, шт',
            'markaModNasosa' => 'Марка модернизируемого насоса / Завод-изготовитель',
            'proizvod' => 'Производство, где установлен насос',
            'markaBPY' => 'Марка БПУ',
            'climatIspolnAndKateg' => 'Климатическое исполнение и категория размещения по ГОСТ 15150-69',
            'classVzryvoopasPomeshch' => 'Класс взрывоопасности помещения по ПУЭ',

            'tempOkrVozdukhaMin' => ' ',
            'tempOkrVozdukhaMax' => ' ',
            'namePerekachZhid' => 'Наименование перекачиваемой жидкости и процентный состав ее компонентов',
            'tempRabPlotn' => 'Плотность, кг/м3',
            'tempRabVyazkost' => 'Вязкость, мм2/с',
            'davlNasyshchParol' => 'Давление насыщенных паров при раб. температуре, МПа (кгс/см2), абс.',

            'toksichPoGOST' => 'Токсичность по ГОСТ 12.1.005-88, (ПДК мг/м3)',
            'classOpasPoGOST' => 'Класс опасности по ГОСТ 12.1.007-76',
            'vzryvoopasPoGOST' => 'Взрывоопасность по ГОСТ Р 51330.5-99',
            'pH' => 'Показатель рН водных растворов',
            'polymerization' => 'Полимеризация, кристаллизация и т.п.',
            'naznachNasosa' => 'Назначение насоса',

            'chastotaVrashch' => 'Частота вращения, об/мин',
            'napravlVrashch' => 'Направление вращения',
            'podacha' => 'Подача, м3/ч',
            'napor' => 'Напор, м',
            'davlInSistPeredVkhod' => ' ',
            'davlInSistPosleNasosa' => ' ',

            'sushchProblNasosa' => 'Существующие проблемы насоса',
            'nameZatvorZhidk' => 'Наименование затворной жидкости',
            'davlMPa' => 'Давление, МПа (кгс/см2), изб.',
            'temperat' => 'Температура, °С',
            'osobTrebovan' => 'Особые требования',
            'typeElektrodvig' => 'Тип электродвигателя',

            'moshchnost' => 'Мощность, кВт',
            'napryazheniye' => 'Напряжение, В',
            'chastotaVrashch2' => 'Частота вращения, об/мин',
            'BPYpoln' => 'БПУ в полном объеме по ТУ с системой СБиПАЗ',
            'BPYnepoln' => 'БПУ (неполный объем), перечень',
            'trebpvanKIPiA' => 'Требования к КИПиА',


        ];
    }


    public function rules()
    {
        return [
            [[
                'nameOrg', 'addressOrg', 'codeCity', 'fax','FIO','position','phone',
                'count', 'markaModNasosa', 'proizvod', 'markaBPY','climatIspolnAndKateg','classVzryvoopasPomeshch',
                'tempOkrVozdukhaMin', 'tempOkrVozdukhaMax', 'namePerekachZhid', 'tempRabPlotn','tempRabVyazkost','davlNasyshchParol',
                'toksichPoGOST', 'classOpasPoGOST', 'vzryvoopasPoGOST', 'pH','polymerization','naznachNasosa',
                'chastotaVrashch', 'napravlVrashch', 'podacha', 'napor','davlInSistPeredVkhod','davlInSistPosleNasosa',
                'sushchProblNasosa', 'nameZatvorZhidk', 'davlMPa', 'temperat','osobTrebovan','typeElektrodvig',
                'moshchnost', 'napryazheniye', 'chastotaVrashch2', 'BPYpoln','BPYnepoln','trebpvanKIPiA'
            ], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['count', 'integer', 'message' => 'Знаение поля должно быть целым числом !!!']


        ];
    }



    public function order4()
    {
        $type4 = new Type1();
        $type4->nameOrg = $this->nameOrg;
        $type4->addressOrg = $this->addressOrg;
        $type4->codeCity = $this->codeCity;
        $type4->fax = $this->fax;
        $type4->FIO = $this->FIO;
        $type4->position = $this->position;
        $type4->phone = $this->phone;

        $type4->count = $this->count;
        $type4->markaModNasosa = $this->markaModNasosa;
        $type4->proizvod = $this->proizvod;
        $type4->markaBPY = $this->markaBPY;
        $type4->climatIspolnAndKateg = $this->climatIspolnAndKateg;
        $type4->classVzryvoopasPomeshch = $this->classVzryvoopasPomeshch;

        $type4->tempOkrVozdukhaMin = $this->tempOkrVozdukhaMin;
        $type4->tempOkrVozdukhaMax = $this->tempOkrVozdukhaMax;
        $type4->namePerekachZhid = $this->namePerekachZhid;
        $type4->tempRabPlotn = $this->tempRabPlotn;
        $type4->tempRabVyazkost = $this->tempRabVyazkost;
        $type4->davlNasyshchParol = $this->davlNasyshchParol;

        $type4->toksichPoGOST = $this->toksichPoGOST;
        $type4->classOpasPoGOST = $this->classOpasPoGOST;
        $type4->vzryvoopasPoGOST = $this->vzryvoopasPoGOST;
        $type4->pH = $this->pH;
        $type4->polymerization = $this->polymerization;
        $type4->naznachNasosa = $this->naznachNasosa;

        $type4->chastotaVrashch = $this->chastotaVrashch;
        $type4->napravlVrashch = $this->napravlVrashch;
        $type4->podacha = $this->podacha;
        $type4->napor = $this->napor;
        $type4->davlInSistPeredVkhod = $this->davlInSistPeredVkhod;
        $type4->davlInSistPosleNasosa = $this->davlInSistPosleNasosa;

        $type4->sushchProblNasosa = $this->sushchProblNasosa;
        $type4->nameZatvorZhidk = $this->nameZatvorZhidk;
        $type4->davlMPa = $this->davlMPa;
        $type4->temperat = $this->temperat;
        $type4->osobTrebovan = $this->osobTrebovan;
        $type4->typeElektrodvig = $this->typeElektrodvig;

        $type4->moshchnost = $this->moshchnost;
        $type4->napryazheniye = $this->napryazheniye;
        $type4->chastotaVrashch2 = $this->chastotaVrashch2;
        $type4->BPYpoln = $this->BPYpoln;
        $type4->BPYnepoln = $this->BPYnepoln;
        $type4->trebpvanKIPiA = $this->trebpvanKIPiA;

        $type4->zakazFK = $this->zakazFK;

        return $type4->save();
    }



}


