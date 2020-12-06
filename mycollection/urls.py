from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^add_item$', views.add_item),
    #path('', views.index, name='index'),
]