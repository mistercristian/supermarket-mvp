using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;


namespace Supermarket_mvp.Presenters
{
    internal class CategoriaPresenter
    {
        private ICategoriaView view;
        private ICategoriaRepository repository;
        private BindingSource categoriaBindingSource;
        private IEnumerable<CategoriaModel> categoriaList;

        public CategoriaPresenter(ICategoriaView view, ICategoriaRepository repository)
        {
            this.categoriaBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategoria;
            this.view.AddNewEvent += AddNewCategoria;
            this.view.EditEvent += LoadSelectCategoriaToEdit;
            this.view.DeleteEvent += DeleteSeletedCategoria;
            this.view.SaveEvent += SaveCategoria;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriaListBildingSource(categoriaBindingSource);

            loadAllCategoriaList();

            this.view.Show();

        }

        private void loadAllCategoriaList()
        {
            categoriaList = repository.GetAll();
            categoriaBindingSource.DataSource = categoriaList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategoria(object? sender, EventArgs e)
        {
            var categoria = new CategoriaModel();
            categoria.Id = Convert.ToInt32(view.CategoriaId);
            categoria.Name = view.CategoriaName;
            categoria.Observation = view.CategoriaObservation;

            try
            {
                new Common.ModelDataValidation().Validate(categoria);

                if (view.IsEdit)
                {
                    repository.Edit(categoria);
                    view.Message = "categoria edited successfuly";
                }
                else
                {
                    repository.Add(categoria);
                    view.Message = "Categoria added successfuly";
                }
                view.IsSuccessful = true;
                loadAllCategoriaList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
            
        private void CleanViewFields()
        {
            view.CategoriaId = "0";
            view.CategoriaName = "";
            view.CategoriaObservation = "";
        }

    

    private void DeleteSeletedCategoria(object? sender, EventArgs e)
        {
            try
            {
                var categoria = (CategoriaModel)categoriaBindingSource.Current;

                repository.Delete(categoria.Id);
                view.IsSuccessful = true;
                view.Message = "Categoria eliminada con exito";
                loadAllCategoriaList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete categoria";
            }

        }

        private void LoadSelectCategoriaToEdit(object? sender, EventArgs e)
        {
            var categoria = (CategoriaModel)categoriaBindingSource.Current;

            view.CategoriaId = categoria.Id.ToString();
            view.CategoriaName = categoria.Name;
            view.CategoriaObservation = categoria.Observation;

            view.IsEdit = true;

        }

        private void AddNewCategoria(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategoria(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);

            if (emptyValue == false)
            {
                categoriaList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriaList = repository.GetAll();
            }
            categoriaBindingSource.DataSource = categoriaList;
        }
    }
}
