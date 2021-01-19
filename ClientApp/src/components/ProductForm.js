import React from 'react';
import { useForm } from 'react-hook-form';

export const ProductForm = () => {
    
    const { register, handleSubmit } = useForm();

    const onSubmit = (data) => {

    }


    return (
        <form onSubmit={handleSubmit(onSubmit)}>
            
        </form>
    )
}