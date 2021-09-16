<?php

namespace app\models;

use Yii;
use yii\base\BaseObject;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */
class Order2  extends Model
{
    public $nameOrg;
    public $addressOrg;
    public $codeCity;
    public $fax;
    public $FIO;
    public $position;
    public $phone;

    public $count;
    public $nameAndMarka;
    public $izgotovitel;
    public $vid;
    public $raspolozheniye;
    public $vidJob;
    public $ispolzuyemyyeTypeYpl;
    public $materialPoverkhOborud;
    public $polozheniyeVala;
    public $napravlVrashchSoStor;
    public $speedVrashch;
    public $dValaVMesteYstan;
    public $dVnutrBobyshki;
    public $rZakruglBob;
    public $namePerekachProdukta;
    public $rabDavlMin;
    public $rabDavlMax;
    public $rabTemperMin;
    public $rabTemperMax;
    public $sostav;
    public $plotnost;
    public $vyazkost;
    public $pH;
    public $temperKipeniya;
    public $dopustimYtechka;
    public $nalichiyeAbrazivKompon;
    public $himSvoystva;
    public $izmenSvoystvSreda;
    public $nameAndSostavZat;
    public $D;
    public $D1;
    public $D2;
    public $D3;
    public $D4;
    public $Dotv;
    public $N;
    public $L1;
    public $L2;
    public $a;
    public $L3;
    public $L4;
    public $a1;
    public $a3;
    public $osobenGeometriiVala;
    public $zakazFK = 2;

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
            'nameAndMarka' => 'Наименование и марка аппарата, в котором будет установлено уплотнение',
            'izgotovitel' => 'Изготовитель',
            'vid' => 'Вид (реактор, насос, компрессор, другой)',
            'raspolozheniye' => 'Расположение (внутри помещения, снаружи, переносной)',
            'vidJob' => 'Вид работы (непрерывный, периодический – соотношение в часах)',

            'ispolzuyemyyeTypeYpl' => 'Используемые в настоящее время типы уплотнения (сальниковые, манжетные, торцовые, лабиринтные и т.д.)',
            'materialPoverkhOborud' => 'Материал поверхностей оборудования, вала взаимодействующих с рабочей средой',
            'polozheniyeVala' => 'Положение вала (вертикальное, горизонтальное, верхнее, нижнее, др.)',
            'napravlVrashchSoStor' => 'Направление вращения со стороны электродвигателя (левое, правое, др.)',
            'speedVrashch' => 'Скорость вращения, с-1, об/мин',
            'dValaVMesteYstan' => 'Диаметр вала в месте установки уплотнения, Dв, мм',

            'dVnutrBobyshki' => 'Внутренний диаметр бобышки аппарата, Dвн, мм',
            'rZakruglBob' => ' Радиус закругления бобышки, R, мм',
            'namePerekachProdukta' => 'Наименование перекачиваемого продукта',
            'rabDavlMin' => ' ',
            'rabDavlMax' => ' ',

            'rabTemperMin' => ' ',
            'rabTemperMax' => ' ',
            'sostav' => 'Состав (входящие компоненты, % содержания)',
            'plotnost' => 'Плотность, г/см3',
            'vyazkost' => 'Вязкость, см2/с',
            'pH' => 'Показатель pH',
            'temperKipeniya' => 'Температура кипения / воспламенения, °С',

            'dopustimYtechka' => 'Допустимая утечка см3/ч',
            'nalichiyeAbrazivKompon' => 'Наличие абразивных компонентов (размер, мм; соотношение, %)',
            'himSvoystva' => ' Химические свойства (агрессивность, коррозионность, взрыво-пожароопасность, адгезионность, кристаллизация)',
            'izmenSvoystvSreda' => ' Изменение свойств среды во время процессов',
            'nameAndSostavZat' => ' Наименование и состав затворной жидкости в уплотнении (допустимый)',
            'D' => 'D - Максимальный диаметр фланца уплотнения',

            'D1' => 'D1 - Посадочный диаметр бобышки аппарата',
            'D2' => 'D2 - Диаметр окружности центров отверстий под болты крепления',
            'D3' => 'D3 - Наружный диаметр верхнего фланца привода',
            'D4' => 'D4 - Посадочный диаметр верхнего фланца привода',
            'Dotv' => 'Dотв - Диаметр отверстий под болты крепления',
            'N' => 'N - Количество отверстий под болты крепления',

            'L1' => ' L1 - Величина выступа / расточки бобышки аппарата',
            'L2' => 'L2 - Максимальный величина монтажного пространства (до ближайших корпусных деталей от бобышки)',
            'a' => 'α° - Угол расположения крепежных отверстий по отношению к оси окна стойки',
            'L3' => 'L3 - Высота от бобышки аппарата до верхнего фланца уплотнения',
            'L4' => 'L4 - Высота выступа под верхний фланец уплотнения',
            'a1' => 'α1° - Угол расположения штуцеров входа, выхода затворной жидкости по отношению к оси окна стойки',

            'a3' => 'α3° - Угол расположения штуцеров выхода, выхода охлаждающей жидкости по отношению к оси окна стойки',
            'osobenGeometriiVala' => 'Особенности геометрии вала (наличие резьбы, канавок, уступов и т.д.) Их расположение относительно торца бобышки аппарата. Указать при наличии',
        ];
    }


    public function rules()
    {
        return [
            [[
                'nameOrg', 'addressOrg', 'codeCity', 'fax','FIO','position','phone',
                'count', 'nameAndMarka', 'izgotovitel', 'vid','raspolozheniye','vidJob',
                'ispolzuyemyyeTypeYpl', 'materialPoverkhOborud', 'polozheniyeVala', 'napravlVrashchSoStor','speedVrashch','dValaVMesteYstan',
                'dVnutrBobyshki', 'rZakruglBob', 'namePerekachProdukta', 'rabDavlMin','rabDavlMax',
                'rabTemperMin', 'rabTemperMax', 'sostav', 'plotnost','vyazkost','pH','temperKipeniya',
                'dopustimYtechka', 'nalichiyeAbrazivKompon', 'himSvoystva', 'izmenSvoystvSreda','nameAndSostavZat','D',
                'D1', 'D2', 'D3', 'D4','Dotv','N',
                'L1', 'L2', 'a', 'L3','L4','a1','a3', 'osobenGeometriiVala'
            ], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['count', 'integer', 'message' => 'Знаение поля должно быть целым числом !!!']


        ];
    }


    public function order2()
    {
        $type2 = new Type1();
        $type2->nameOrg = $this->nameOrg;
        $type2->addressOrg = $this->addressOrg;
        $type2->codeCity = $this->codeCity;
        $type2->fax = $this->fax;
        $type2->FIO = $this->FIO;
        $type2->position = $this->position;
        $type2->phone = $this->phone;

        $type2->count = $this->count;
        $type2->nameAndMarka = $this->nameAndMarka;
        $type2->izgotovitel = $this->izgotovitel;
        $type2->vid = $this->vid;
        $type2->raspolozheniye = $this->raspolozheniye;
        $type2->vidJob = $this->vidJob;

        $type2->ispolzuyemyyeTypeYpl = $this->ispolzuyemyyeTypeYpl;
        $type2->materialPoverkhOborud = $this->materialPoverkhOborud;
        $type2->polozheniyeVala = $this->polozheniyeVala;
        $type2->napravlVrashchSoStor = $this->napravlVrashchSoStor;
        $type2->speedVrashch = $this->speedVrashch;
        $type2->dValaVMesteYstan = $this->dValaVMesteYstan;

        $type2->dVnutrBobyshki = $this->dVnutrBobyshki;
        $type2->rZakruglBob = $this->rZakruglBob;
        $type2->namePerekachProdukta = $this->namePerekachProdukta;
        $type2->rabDavlMin = $this->rabDavlMin;
        $type2->rabDavlMax = $this->rabDavlMax;

        $type2->rabTemperMin = $this->rabTemperMin;
        $type2->rabTemperMax = $this->rabTemperMax;
        $type2->sostav = $this->sostav;
        $type2->plotnost = $this->plotnost;
        $type2->vyazkost = $this->vyazkost;
        $type2->pH = $this->pH;
        $type2->temperKipeniya = $this->temperKipeniya;

        $type2->dopustimYtechka = $this->dopustimYtechka;
        $type2->nalichiyeAbrazivKompon = $this->nalichiyeAbrazivKompon;
        $type2->himSvoystva = $this->himSvoystva;
        $type2->izmenSvoystvSreda = $this->izmenSvoystvSreda;
        $type2->nameAndSostavZat = $this->nameAndSostavZat;
        $type2->D = $this->D;

        $type2->D1 = $this->D1;
        $type2->D2 = $this->D2;
        $type2->D3 = $this->D3;
        $type2->D4 = $this->D4;
        $type2->Dotv = $this->Dotv;
        $type2->N = $this->N;

        $type2->L1 = $this->L1;
        $type2->L2 = $this->L2;
        $type2->a = $this->a;
        $type2->L3 = $this->L3;
        $type2->L4 = $this->L4;
        $type2->a1 = $this->a1;
        $type2->a3 = $this->a3;
        $type2->osobenGeometriiVala = $this->osobenGeometriiVala;

        $type2->zakazFK = $this->zakazFK;

        return $type2->save();
    }


}


