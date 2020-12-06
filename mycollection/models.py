from django.db import models

class Item(models.Model):
    name = models.CharField(max_length=500)
    brand = models.CharField(max_length=500, blank=True, null=True)
    purchase_price = models.FloatField()
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)
