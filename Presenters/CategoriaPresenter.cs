using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;


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
            throw new NotImplementedException();
        }

        private void SaveCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSeletedCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCategoriaToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
