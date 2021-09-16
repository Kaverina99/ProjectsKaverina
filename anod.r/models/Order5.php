<?php

namespace app\models;

use Yii;
use yii\base\BaseObject;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */
class Order5  extends Model
{
    public $nameOrg;
    public $addressOrg;
    public $codeCity;
    public $fax;
    public $FIO;
    public $position;
    public $phone;

    public $count;
    public $nameAndMarkaApp;
    public $rabSredaInZoneRazm;
    public $chastotaVrashchVala;
    public $massaRotora;
    public $nameRabSreda;

    public $temperat;
    public $davlInPolostiPodsh;
    public $vozmozhPodachiInPol;
    public $osobenGeomVala;
    public $dOpor;
    public $dYpor;

    public $Lopor;
    public $Lypor;
    public $d1opor;
    public $d1ypor;
    public $cOpor;
    public $cYpor;

    public $PocOpor;
    public $PocYpor;

    public $zakazFK = 5;

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
            'nameAndMarkaApp' => ' Наименование и марка аппарата, в котором будет установлено торцовое уплотнение',
            'rabSredaInZoneRazm' => ' Рабочая среда в зоне размещения подшипника',
            'chastotaVrashchVala' => 'Частота вращения вала, с-1, об/мин',
            'massaRotora' => 'Масса ротора, кг',
            'nameRabSreda' => 'Наименование рабочей среды',

            'temperat' => 'Температура рабочей среды, °С',
            'davlInPolostiPodsh' => ' Давление в полости подшипника, МПа (кг/см2)',
            'vozmozhPodachiInPol' => ' Возможность подачи в полость подшипника «чистой среды», совместно с перекачиваемой',
            'osobenGeomVala' => 'Особенности геометрии вала (наличие резьбы, канавок, уступов и и.д.) Их расположение относительно торца сальниковой камеры',
            'dOpor' => ' ',
            'dYpor' => ' ',

            'Lopor' => ' ',
            'Lypor' => ' ',
            'd1opor' => ' ',
            'd1ypor' => ' ',
            'cOpor' => ' ',
            'cYpor' => ' ',

            'PocOpor' => ' ',
            'PocYpor' => ' '
        ];
    }



    public function rules()
    {
        return [
            [[
                'nameOrg', 'addressOrg', 'codeCity', 'fax','FIO','position','phone',
                'count', 'nameAndMarkaApp', 'rabSredaInZoneRazm', 'chastotaVrashchVala','massaRotora','nameRabSreda',
                'temperat', 'davlInPolostiPodsh', 'vozmozhPodachiInPol', 'osobenGeomVala','dOpor','dYpor',
                'Lopor', 'Lypor', 'd1opor', 'd1ypor','cOpor','cYpor',
                'PocOpor', 'PocYpor'
            ], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['count', 'integer', 'message' => 'Знаение поля должно быть целым числом !!!']


        ];
    }



    public function order5()
    {
        $type5 = new Type1();
        $type5->nameOrg = $this->nameOrg;
        $type5->addressOrg = $this->addressOrg;
        $type5->codeCity = $this->codeCity;
        $type5->fax = $this->fax;
        $type5->FIO = $this->FIO;
        $type5->position = $this->position;
        $type5->phone = $this->phone;

        $type5->count = $this->count;
        $type5->nameAndMarkaApp = $this->nameAndMarkaApp;
        $type5->rabSredaInZoneRazm = $this->rabSredaInZoneRazm;
        $type5->chastotaVrashchVala = $this->chastotaVrashchVala;
        $type5->massaRotora = $this->massaRotora;
        $type5->nameRabSreda = $this->nameRabSreda;

        $type5->temperat = $this->temperat;
        $type5->davlInPolostiPodsh = $this->davlInPolostiPodsh;
        $type5->vozmozhPodachiInPol = $this->vozmozhPodachiInPol;
        $type5->osobenGeomVala = $this->osobenGeomVala;
        $type5->dOpor = $this->dOpor;
        $type5->dYpor = $this->dYpor;

        $type5->Lopor = $this->Lopor;
        $type5->Lypor = $this->Lypor;
        $type5->d1opor = $this->d1opor;
        $type5->d1ypor = $this->d1ypor;
        $type5->cOpor = $this->cOpor;
        $type5->cYpor = $this->cYpor;

        $type5->PocOpor = $this->PocOpor;
        $type5->PocYpor = $this->PocYpor;

        $type5->zakazFK = $this->zakazFK;

        return $type5->save();
    }


}


