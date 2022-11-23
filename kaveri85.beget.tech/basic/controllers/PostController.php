<?php

namespace app\controllers;

use Yii;
use yii\filters\AccessControl;
use yii\web\Controller;
use yii\web\Response;
use yii\filters\VerbFilter;
use app\models\CommentForm;
use app\models\AddPostForm;
use app\models\Comment;
use app\models\Posts;
use app\models\AddTagPostForm;
use app\models\TagPost;

class PostController extends Controller
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

    public function actionIndex()
    {
        $model = new AddPostForm();
        if ( $model->load(Yii::$app->request->post()) ) {
            $data = Yii::$app->request->post()['AddPostForm'];
            $addpost = new Posts();
            $addpost->title = $data['title'];
            $addpost->content = $data['content'];
            $addpost->alias = $data['alias'];
            $addpost->image_url = $data['image_url'];
            $addpost->save();

            return $this->render('index', ['model' => $model]);
        }
        return $this->render('index', ['model' => $model]);
    }

    public function actionView()
    {
        $alltags = \app\models\Tag::find()->all();
        
        foreach ($alltags as $key => $value) {
            $alltag[$value['id']] = $value['title']; 
        }

        $alias = \Yii::$app->request->get('alias'); 
        $post = \app\models\Posts::find()->where(['alias' => $alias])->one();
        $tagpost = \app\models\TagPost::find()->where(['post_FK' => $post['id']])->all();
        foreach ($tagpost as $key => $value) {
             $tagname[] = \app\models\Tag::find()->where(['id' => $value['tag_FK']])->all();
        }
        $comment_post = \app\models\Comment::find()->where(['post_FK' => $post['id']])->all();


        $model = new CommentForm();
        if ( $model->load(Yii::$app->request->post()) ) {
            $data = Yii::$app->request->post()['CommentForm'];
            $comment = new Comment();
            $comment->full_name = $data['full_name'];
            $comment->content = $data['content'];
            $comment->post_FK = $data['post_FK'];
            $comment->save();

            return $this->render('single', ['model' => $model, 'model2' => $model2, 'post' => $post, 'tagname' => $tagname, 'comment_post' => $comment_post, 'alltag' => $alltag]);
        }

        $model2 = new AddTagPostForm();
        if ( $model2->load(Yii::$app->request->post()) ) {
            $data2 = Yii::$app->request->post()['AddTagPostForm'];
            $addtagpost = new TagPost();
            $addtagpost->tag_FK = $data2['tag_FK'];
            $addtagpost->post_FK = $data2['post_FK'];
            $addtagpost->save();

            return $this->render('single', ['model' => $model, 'model2' => $model2, 'post' => $post, 'tagname' => $tagname, 'comment_post' => $comment_post, 'alltag' => $alltag]);
        }


        return $this->render('single', ['model' => $model, 'model2' => $model2, 'post' => $post, 'tagname' => $tagname, 'comment_post' => $comment_post, 'alltag' => $alltag]);
    }

    
}
