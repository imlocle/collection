from django.http import HttpResponse
from django.shortcuts import render, redirect

def index(request):
    return render(request, 'mycollection/index.html')

def add_item(request):
    name = request.POST["name"]
    brand = request.POST['brand']
    print(f'{name} {brand}')
    return redirect('/')
