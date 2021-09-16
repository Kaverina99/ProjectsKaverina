<?php

namespace app\controllers;

use app\controllers\SotrudnikiController;

use app\models\Chat;
use app\models\Login;
use app\models\Logout;
use app\models\Message;
use app\models\Order1;
use app\models\Order2;
use app\models\Order3;
use app\models\Order4;
use app\models\Order5;
use app\models\Order6;
use app\models\Myorders;
use app\models\Status;
use app\models\Type1;
use app\models\Type2;
use app\models\Type3;
use app\models\Type4;
use app\models\Type5;
use app\models\Type6;
use app\models\Updatecab;
use app\models\User;
use app\models\Zakaz;
use Yii;
use yii\base\BaseObject;
use yii\data\ActiveDataProvider;
use yii\data\Pagination;
use yii\db\Query;
use yii\filters\AccessControl;
use yii\web\Controller;
use yii\web\Response;
use yii\filters\VerbFilter;
use app\models\Signup;
use app\models\ContactForm;

class SiteController extends Controller
{
    /**
     * {@inheritdoc}
     */
    public function behaviors()
    {
        return [
            'access' => [
                'class' => AccessControl::className(),
                'only' => ['logout'],
                'rules' => [
                    [
                        'actions' => ['logout'],
                        'allow' => true,
                        'roles' => ['@'],
                    ],
                ],
            ],
            'verbs' => [
                'class' => VerbFilter::className(),
                'actions' => [
                    'logout' => ['post'],
                ],
            ],
        ];
    }

    /**
     * {@inheritdoc}
     */
    public function actions()
    {
        return [
            'error' => [
                'class' => 'yii\web\ErrorAction',
            ],
            'captcha' => [
                'class' => 'yii\captcha\CaptchaAction',
                'fixedVerifyCode' => YII_ENV_TEST ? 'testme' : null,
            ],
        ];
    }

    /**
     * Displays homepage.
     *
     * @return string
     */
    public function actionIndex()
    {
        return $this->render('index');
    }

    public function actionRegions()
    {
        return $this->render('regions');
    }

    public function actionServis()
    {
        return $this->render('servis');
    }

    public function actionProduct()
    {
        return $this->render('product');
    }


    public function actionOrder()
    {
        return $this->render('order');
    }

    public function actionCabinet()
    {
        $model = User::findOne(Yii::$app->user->identity->getId());
        return $this->render('cabinet', ['model'=>$model]);
    }

    public function actionOrder1()
    {
        $model = new Order1();
        if(isset($_POST['Order1'])){
            $model->attributes = Yii::$app->request->post('Order1');
            if($model->validate() && $model->order1()) {
                return $this->render('order');
            }
        }
        return $this->render('order1', ['model'=>$model]);
    }

    public function actionOrder2()
    {
        $model = new Order2();
        if(isset($_POST['Order2'])){
            $model->attributes = Yii::$app->request->post('Order2');
            if($model->validate() && $model->order2())
                return $this->goHome();
        }
        return $this->render('order2', ['model'=>$model]);

    }
    public function actionOrder3()
    {
        $model = new Order3();
        if(isset($_POST['Order3'])){
            $model->attributes = Yii::$app->request->post('Order3');
            if($model->validate() && $model->order3())
                return $this->goHome();
        }
        return $this->render('order3', ['model'=>$model]);
    }

    public function actionOrder4()
    {
        $model = new Order4();
        if(isset($_POST['Order4'])){
            $model->attributes = Yii::$app->request->post('Order4');
            if($model->validate() && $model->order4())
                return $this->goHome();
        }
        return $this->render('order4', ['model'=>$model]);
    }
    public function actionOrder5()
    {
        $model = new Order5();
        if(isset($_POST['Order5'])){
            $model->attributes = Yii::$app->request->post('Order5');
            if($model->validate() && $model->order5())
                return $this->goHome();
        }
        return $this->render('order5', ['model'=>$model]);
    }
    public function actionOrder6()
    {
        $model = new Order6();
        if(isset($_POST['Order6'])){
            $model->attributes = Yii::$app->request->post('Order6');
            if($model->validate() && $model->order6())
                return $this->goHome();
        }
        return $this->render('order6', ['model'=>$model]);
    }


    public function actionHistory()
    {
        return $this->render('history');
    }

    public function actionOffice()
    {
        if(!Yii::$app->user->isGuest)
        {
            return $this->render('logout');
        }

        return $this->render('office');
    }


    public function actionProduct1()
    {
        return $this->render('product1');
    }

    public function actionProduct2()
    {
        return $this->render('product2');
    }

    public function actionProduct3()
    {
        return $this->render('product3');
    }

    public function actionProduct4()
    {
        return $this->render('product4');
    }

    public function actionProduct5()
    {
        return $this->render('product5');
    }

    public function actionProduct6()
    {
        return $this->render('product6');
    }

    public function actionSertif()
    {
        return $this->render('sertif');
    }

    public function actionPatents()
    {
        return $this->render('patents');
    }

    /**
     * Displays contact page.
     *
     * @return Response|string
     */
    public function actionContact()
    {
        $model = new ContactForm();
        if ($model->load(Yii::$app->request->post()) && $model->contact(Yii::$app->params['adminEmail'])) {
            Yii::$app->session->setFlash('contactFormSubmitted');

            return $this->refresh();
        }
        return $this->render('contact', [
            'model' => $model,
        ]);
    }

    public function actionUpdatecab()
    {
        $model = User::findOne(Yii::$app->user->identity->getId());
        if ($model->load(Yii::$app->request->post()))
        {
            $model->save();
            return $this->render('cabinet', ['model'=>$model]);
        }
        return $this->render('updatecab', ['model'=>$model]);

    }



    public function actionSignup()
    {
        $model = new Signup();
        if(isset($_POST['Signup'])){
            $model->attributes = Yii::$app->request->post('Signup');

            if($model->validate() && $model->signup())
                return $this->goHome();
        }
        return $this->render('signup', ['model'=>$model]);
    }

    public function actionLogin(){

       /* $login_model = new Login();

        if(Yii::$app->user->isGuest)
        {
            if (Yii::$app->request->post('Login')){
                $login_model->attributes = Yii::$app->request->post('Login');

                if ($login_model->validate())
                {
                    Yii::$app->user->login($login_model->getUser());

                    if (User::find()->asArray()->where(['id' => Yii::$app->user->identity->getId()])->all()[0][roleFK] == 1)
                        Yii::$app->getResponse()->redirect( '/index.php?r=admin/index' )->send();
                    else if (User::find()->asArray()->where(['id' => Yii::$app->user->identity->getId()])->all()[0][roleFK] == 2)
                        return $this->render('index');
                    else if (User::find()->asArray()->where(['id' => Yii::$app->user->identity->getId()])->all()[0][roleFK] == 3)
                        Yii::$app->getResponse()->redirect( '/index.php?r=sotrudniki/index' )->send();

                }
            }
            return $this->render('login', ['login_model'=>$login_model]);
        }
        else
        {
            return $this->render('login');
        }
       */



        $login_model = new Login();

        if (Yii::$app->request->post('Login')){
            $login_model->attributes = Yii::$app->request->post('Login');

            if ($login_model->validate())
            {
                Yii::$app->user->login($login_model->getUser());
                return $this->goHome();

            }
        }

        return $this->render('login', ['login_model'=>$login_model]);



    }


    public function actionLogout()
    {
        $model = new Logout();
        return $this->render('logout', [
            'model' => $model,
        ]);


      /*  else
        {
            $ar = User::find()->asArray()->where(['id' => Yii::$app->user->identity->getId()])->all();
            if($ar[0][roleFK] == 2)
            {
                return $this->render('logout', ['model' => $model,]);
            }
            else if ($ar[0][roleFK] == 3)
            {
                return render('/index.php?r=sotrudniki');
                return $this->render('logout2');

                //return $this->render('/web/index.php?r=sotrudniki');
            }
        }*/


    }

    public function actionOff()
    {
        return $this->render('off');
    }


    public function actionMyorders()
    {

        $query = Zakaz::find()->where(['clientFK' => Yii::$app->user->identity->getId()]);

       /* $query = new Query;
        $query->select(['zakaz.id','zakaz.nameOrg', 'zakaz.FIO', 'status.name'])
            ->from('zakaz')
            ->innerJoin('status', 'zakaz.statusFK=status.id')
            ->andWhere(['clientFK' => Yii::$app->user->identity->getId()])
            ->createCommand()->queryAll();
       */


        $dataProvider = new ActiveDataProvider([
            'query' => $query,
            'pagination' => [
                'pageSize' => 7,
            ],
        ]);

        return $this->render('myorders', ['dataProvider'=>$dataProvider]);

    }


    public function actionView($id)
        {
            $model = Zakaz::findOne($id);

            $model2 = Type1::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
            $type = 'Заказ торцовых уплотнений для насосов';
            if ($model2 == NULL) {
                $model2 = Type2::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
                $type = 'Заказ торцовых уплотнений для реакторов и мешалок'; }
            if ($model2 == NULL) {
                $model2 = Type3::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
                $type = 'Заказ насосных агрегатов'; }
            if ($model2 == NULL) {
                $model2 = Type4::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
                $type = 'Заказ подшипниково-уплотнительных блоков'; }
            if ($model2 == NULL) {
                $model2 = Type5::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
                $type = 'Заказ подшипников скольжения'; }
            if ($model2 == NULL) {
                $model2 = Type6::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
                $type = 'Заказ на изготовление арматуры'; }


            return $this->render('view', ['type'=>$type, 'model'=>$model, 'model2'=>$model2]);

        }


    public function actionMessage()
    {
        $rows = Chat::find()->where(['clientFK' => Yii::$app->user->identity->getId(), 'sotrudnikFK' => 7])->all();

        $model = new Message();
        if(isset($_POST['Message'])){
            $model->attributes = Yii::$app->request->post('Message');
            if($model->validate() && $model->message()) {
                $rows = Chat::find()->where(['clientFK' => Yii::$app->user->identity->getId(), 'sotrudnikFK' => 7])->all();
                $model->message =' ';
                return $this->render('message', ['rows'=>$rows, 'model'=>$model]);
            }
        }

        return $this->render('message', ['rows'=>$rows, 'model'=>$model]);

    }

}


















